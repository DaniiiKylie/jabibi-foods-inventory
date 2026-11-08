# Creates mabalot_try\jabibi.accdb and runs schema.sql against it.
# Needs the 64-bit Microsoft Access Database Engine, so run it from 64-bit Windows PowerShell:
#   powershell -NoProfile -ExecutionPolicy Bypass -File database\create-database.ps1
param(
    [string]$Path = (Join-Path $PSScriptRoot '..\mabalot_try\jabibi.accdb')
)

$ErrorActionPreference = 'Stop'
$Path = [System.IO.Path]::GetFullPath($Path)

if (Test-Path -LiteralPath $Path) {
    throw "$Path already exists. Delete it first to start over."
}

$connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=$Path"

# ADOX makes the empty .accdb file.
$catalog = New-Object -ComObject ADOX.Catalog
[void]$catalog.Create($connectionString)
$catalog.ActiveConnection.Close()
[void][System.Runtime.InteropServices.Marshal]::ReleaseComObject($catalog)

# Access runs one statement per command, so split the file at each semicolon and drop comment lines.
$sql = Get-Content -LiteralPath (Join-Path $PSScriptRoot 'schema.sql') -Raw
$withoutComments = ($sql -split "`r?`n" | Where-Object { $_ -notmatch '^\s*--' }) -join "`n"
$statements = $withoutComments -split ';' | ForEach-Object { $_.Trim() } | Where-Object { $_ }

$connection = New-Object System.Data.OleDb.OleDbConnection $connectionString
$connection.Open()
try {
    foreach ($statement in $statements) {
        $command = $connection.CreateCommand()
        $command.CommandText = $statement
        [void]$command.ExecuteNonQuery()
        Write-Output ("Ran: " + ($statement -split "`n")[0])
    }
}
finally {
    $connection.Close()
}

Write-Output "Created $Path"
