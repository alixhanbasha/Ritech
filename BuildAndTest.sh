#!/bin/bash

# Build the assignement project
# Run the tests, and generate the HTML reports.

# Checking the OS
OS=$(uname)
if [[ "$OS" != "Linux" ]]; then
    echo "Cannot run this script safely because your OS is not supported"
    exit
fi

# Making sure that the OS has 'apt' which is the package manager
# for all Debian derivatives
command -v apt $>/dev/null || {
    echo "Your OS is not a Debian derivative like Ubuntu. This script cannot run safely."
    exit
}


DOTNET_TEST="dotnet test"


if [[ $# -eq 0 ]]; then 
    echo "No test filter provided. Will run *.feature"
else
    DOTNET_TEST="dotnet test --filter $1"
fi

command -v appium &>/dev/null || {
    echo "Appium is not installed. Installing it now."
    npm i --location=global appium
    if [[ $? -eq 0 ]]; then
        echo "Could not install Appium. This is a hard dependency so please install it manually"
        exit 1
    fi

    echo "Appium has been installed. Installing other dependencies..."
    appium driver install uiautomator2
    appium plugin install --source=npm appium-gestures-plugin

}

command -v livingdoc &>/dev/null || {
    echo "livingdoc binary not installed."
    echo "Installing livingdoc..."
    dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
}

# Building the project
dotnet build
if [[ $? -ne 0 ]]; then
    echo "Could not build the Ritech QA assignement. Something went wrong..."
    exit 1
fi

# Running the tests
$DOTNET_TEST && {
    printf "\n\nTests are completed. Generating reports...\n"
    livingdoc test-assembly ./bin/Debug/net8.0/Ritech.dll -t ./bin/Debug/net8.0/TestExecution.json
}
