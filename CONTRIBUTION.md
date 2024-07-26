Please follow the rules when submitting code:

# 1. HTTP Status Code

Make sure to return the correct HTTP status code.

HTTP Status Code | HTTP Method | Scenario
-- | -- | --
200 | GET | server return data successfully
201 | POST/PUT/PATCH | client update data successfully
202 | * | server has received the request and pushed to a queue (asynchronous)
204 | * | no content
400 | POST/PUT/PATCH | the request parameters are invalid
401 | * | token is invalid or expired
403 | * | access is forbidden
404 | * | not found
422 | POST/PUT/PATCH | entity cannot be processed
429 | * | too many requests
499 | * | client closed the connection
500 | * | server internal error

# 2. Pull Request

Make sure that you provide the following information in either PR title or PR description.

- jira ticket
- team
- arch proposal link
- intended for release branch: yes | no
- type of the change: feature | bugfix | translation import | technical | documentation | other
- short description of the purpose of the PR
- screenshots

