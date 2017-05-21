jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "CalculateAdditionOperations.feature",
      "Feature": {
        "Name": "Calculator addition operations",
        "Description": "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of two numbers",
        "FeatureElements": [
          {
            "Name": "Add two numbers",
            "Slug": "add-two-numbers",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have entered 50 into the calculator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have pressed the plus key",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have entered 70 into the calculator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I press the equal key",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result on the screen should be 120",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@addition"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "First value",
                    "Second value",
                    "Output",
                    "Reason"
                  ],
                  "DataRows": [
                    [
                      "one",
                      "two",
                      "3",
                      "string inputs until three are valid"
                    ],
                    [
                      "four",
                      "1",
                      "ERR",
                      "string inputs over three will result in error"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Valid inputs when adding two numbers",
            "Slug": "valid-inputs-when-adding-two-numbers",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have entered <First value> into the calculator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have pressed the plus key",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have entered <Second value> into the calculator",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I press the equal key",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result on the screen should be <Output>",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Background": {
          "Name": "",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have a calculator",
              "StepComments": [],
              "AfterLastStepComments": []
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "CalculateArithmeticExpressions.feature",
      "Feature": {
        "Name": "Calculator arithmetic expressions",
        "Description": "In order to avoid silly mistakes \r\nAs a math idiot \r\nI want to be able to perform arithmetic on the calculator",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "First value",
                    "Operation",
                    "Second value",
                    "Output"
                  ],
                  "DataRows": [
                    [
                      "one",
                      "plus",
                      "one",
                      "2"
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Calculating expressions",
            "Slug": "calculating-expressions",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have entered the following expression in the calculator",
                "TableArgument": {
                  "HeaderRow": [
                    "Field",
                    "Value"
                  ],
                  "DataRows": [
                    [
                      "First value",
                      "<First value>"
                    ],
                    [
                      "Operation",
                      "<Operation>"
                    ],
                    [
                      "Second value",
                      "<Second value>"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I press the equal key",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result on the screen should be <Output>",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@subtraction"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Background": {
          "Name": "",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have a calculator",
              "StepComments": [],
              "AfterLastStepComments": []
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@addition",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@subtraction",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "CalculateAdditionOperations.feature",
        "Total": 2,
        "Passing": 2,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "CalculateArithmeticExpressions.feature",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "CalculateAdditionOperations.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "CalculateArithmeticExpressions.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 3,
      "Passing": 3,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 2,
      "Passing": 2,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "GeneratedOn": "21 May 2017 19:07:27"
  }
});