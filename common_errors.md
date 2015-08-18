# Expected failure 
There are two levels of failure : 
  * partial_success, which means that some of the requested values were valid for the service, the input values that failed should be corrected and retried if it makes sence.
  * failed, none of the input values were valid for the service, this means the request should not be retried, input format could be wrong or the state of the values is not what was expected. If the http returncode is 400 it means the formatting of the request is wrong and there is a programming error.

# Logged out
Once in a while a session is dropped, usually this is because the IP of the client has changed but it could also be a reset of sessions on SimService side. Whenever this happends a 401 http response is returned. 

# Common Errors
The real world is not perfect and another program or person might change the network status of a simcard, this would likely result in an error, which likely would need handling by updating local data, or contacting simservice.
The following table contains errors which should be handled.

Api Call | Simple Message   |    Full Description       
--------- | ---------------- | -------------------------
All | imsi.not_in_domain | Imsi is not in specified domain
Network Change | imsi.already_scheduled_transactions | There are another transaction already scheduled for this imsi
Activation | imsi.already_activated | Imsi has already been activated
Suspension  |  imsi.not_active | Imsi is not active
Unsuspension | imsi.not_suspended | Imsi is not suspended
