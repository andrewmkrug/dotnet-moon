#!/bin/bash

cd ../
echo "Do you want to remove the latest migration (y/n): "
read -r UserPromptResult

if [ "$UserPromptResult" = "y" ]
then
    echo "Removing the latest migration from SQL Server..."
    dotnet ef migrations remove --project ../sample.Migrations.SqlServer -- --provider SqlServer



fi

echo "Removed the latest migration"
