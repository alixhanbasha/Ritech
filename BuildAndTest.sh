#!/bin/bash

# Build the assignement project project
# Run the tests, and generate the HTML reports.

DOTNET_TEST="dotnet test"

if [[ $# -eq 0 ]]; then 
    echo "No test filter provided. Will run *.feature"
else
    DOTNET_TEST="dotnet test --filter Category=$1"
fi

command -v livingdoc &>/dev/null || {
    echo "livingdoc binary not installed."
    echo "Installing livingdoc..."
    dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
}

dotnet build
if [[ $? -ne 0 ]]; then
    echo "Could not build the Ritech QA assignement. Something went wrong..."
    exit 1
fi


$DOTNET_TEST && {
    printf "\n\nTests are completed. Generating reports...\n"
    livingdoc test-assembly ./bin/Debug/net8.0/Ritech.dll -t ./bin/Debug/net8.0/TestExecution.json
}
