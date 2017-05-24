Login
==========================

This automation for login test steps.

* Go to "http://www.mizu.com"
* I see url is "https://www.mizu.com/"
* Click ".header__login" element
* I see url is "https://www.mizu.com/uyelik"

Invalid Login
-----------

* Fill ".login__left #Email" as "invalidmail@example.com"
* Fill ".login__left #Password" as "invalidpassword"
* Click ".login__btn-member" element
* I see url is "https://www.mizu.com/uyelik"

Valid Login
-----------

* Fill ".login__left #Email" as "validmail@example.com"
* Fill ".login__left #Password" as "validpassword"
* Click ".login__btn-member" element
* I see url is "https://www.mizu.com/"