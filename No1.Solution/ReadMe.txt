﻿Каждое правило валидации содержится в отедльном классе, каждый класс валидации 
реализует интерфейс IValidation. Создан интерфейс репозитория для создания пароля. 
Класс SqlRepository реализует интерфейс репозитория. Класс PasswordCheckerService  
принимает в конструкторе пароль, стратегию сохранения в репозиторий, коллекцию стратегий валидации, 
публичный метод VerifyPassword для вызова валидации пароля.
