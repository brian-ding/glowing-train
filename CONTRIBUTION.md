Please follow the rules when submitting code:

# 1. HTTP Status Code

Make sure to return the correct HTTP status code.

HTTP Status Code | HTTP Method | Scenario
-- | -- | --
204 | * | no content
400 | POST/PUT/PATCH | the request parameters are invalid
404 | * | not found
422 | POST/PUT/PATCH | entity cannot be processed
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

# 3. Code Standard

- You must use refit library for ApsnetCore outbound http request, don't use IHttpClientFactory directly.
- You must add BMW-Correlation-Id header in each outbound http request headers.
- You must add Caller-Cluster-Name header in each outbound http request headers.
