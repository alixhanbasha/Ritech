@Forms
Feature: WebDriverIO Form
![Calculator](https://img.freepik.com/free-vector/fill-out-concept-illustration_114360-5560.jpg?t=st=1732194829~exp=1732198429~hmac=bcc3f6af814d63702e99fae041085bfd1c5e51fc4e5a8200d4cfb4979871e400&w=300)

The user can fill in and submit a form, can select multiple
options from the dropdown, and trigger an alert popup.

Link to a feature: [Forms]($projectname$/Features/Forms.feature)

  @Forms_01
  Scenario Outline: 1 As a user of webdriverio James wants to fill in the form
    Given James is a user of webdriverio app
    When He wants to fill in the form with details
    Then He selects "<message>" from the dropdown
    Then He submits the form

    Examples:
      | message                 |
      | Appium is awesome       |
      | webdriver.io is awesome |
      | This app is awesome     |
