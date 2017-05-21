jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "SearchForBooks.feature",
      "Feature": {
        "Name": "Search for books",
        "Description": "In order to find quickly books of favorite authors\r\nAs a cusmtomer\r\nI want to be able to see books list for a certain author",
        "FeatureElements": [
          {
            "Name": "Search for books by author",
            "Slug": "search-for-books-by-author",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigated to Amazon home page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I search for author \"Emilian Balanescu\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the first result on the screen should be \"Beginning PHP and PostgreSQL E-Commerce: From Novice to Professional (Beginning, from Novice to Professional)\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@amazon"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
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
        "Tag": "@amazon",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "SearchForBooks.feature",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "SearchForBooks.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 1,
      "Passing": 1,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 1,
      "Passing": 1,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "GeneratedOn": "21 May 2017 19:10:39"
  }
});