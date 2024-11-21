@Login
Feature: The Login screen
![Login](https://img.freepik.com/free-vector/login-concept-illustration_114360-739.jpg?t=st=1732149485~exp=1732153085~hmac=9f5f748229fe8c1653c266900aaf44dd479995e8bd6f721997fb2f975751454d&w=300)

The user can enter his/her email and password, click "Login" and a popup will show up if the 
credentials are "registered" and valid. Otherwise the user will se some error based on his/her actions.

Link to a feature: [Login]($projectname$/Features/Login.feature)

  @Login_01
  Scenario: 1 As a user of webdriverio app, Simon can login using his credentials
    Given Simon is a user of webdriverio app
    When He wants to login
    When He enters the correct credentials
    Then He will see a success alert

  @Login_02
  Scenario: 2 As a user of webdriverio app, Brad does not enter a properly formated email
    Given Brad is a user of webdriverio app
    When He wants to login
    When He enters a malformed email address
    Then He will see the "Please enter a valid email address" message

  @Login_03
  Scenario: 3 As a user of webdriverio app, Tim enters an insecure password
    Given Tim is a user of webdriverio app
    When He wants to login
    When He enters an insecure password
    Then He will see the "Please enter at least 8 characters" message

  @Login_04
  Scenario: 4 As a user of webdriverio app, Jeff enters invalid credentials
    Given Jeff is a user of webdriverio app
    When He wants to login
    When He enters invalid credentials
    Then He will see the "Please enter a valid email address" message
    Then He will see the "Please enter at least 8 characters" message

  @Login_05
  Scenario: 5 As a user of webdriverio app, Ron tries to login without writting any credentials
    Given Ron is a user of webdriverio app
    When He wants to login
    When He enters empty credentials
    Then He will see the "Please enter a valid email address" message
    Then He will see the "Please enter at least 8 characters" message
