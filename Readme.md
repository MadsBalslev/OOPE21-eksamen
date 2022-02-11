# EZ 12 GG

# Del 1: Stregsystemets kerne
Stregsystemet skal administrere brugere, produkter, og transaktioner mellem disse.
## Classes
### User
En bruger har følgende egenskaber:
- [x] `ID`
- [x] `Firstname`
- [x] `Lastname`
- [x] `Username`
- [x] `Email`
- [ ] `Balance`
- [x] `ToString`

### Product
Et produkt har følgende egenskaber:
- [x] `ID`
- [x] `Name`
- [x] `Price`
- [x] `Active`
- [ ] `CanBeBoughtOnCredit`
- [x] `ToString`

### SeasonalProduct
Denne type produkter har følgende egenskaber:
- [x] `ID`
- [x] `Name`
- [x] `Active`
- [x] `Price`
- [ ] `CanBeBoughtOnCredit`
- [x] `SeasonStartDate`
- [x] `SeasonEndDate`

### Transaction
Transaktioner beskriver køb og indsættelse af penge. Generelt kan man sige følgende om transaktioner:
- [ ] `ID`
- [x] `User`
- [x] `Date`
- [x] `Amount`
- [x] `ToString`
- [ ] `Execute`

#### InsertCashTransaction
InsertCachTransaction bruges når der skal optankes penge på brugerens konto, og har følgende:
- [ ] `ToString`
- [ ] `Execute`

#### BuyTransaction
BuyTransaction bruges til at repræsentere køb, og er karakteriseret ved følgende
- [ ] `Product`
- [ ] `Amount`
- [ ] `ToString`
- [ ] `Execute`

### Stregsystem
Stregsystem indeholder ren logik vedrørende brugere, transaktioner og lignende. Det betyder at stregsystem indeholder informationer om brugere, produkter og transaktioner.
Stregsystemet har følgende skitserede metoder og properties:
- [ ] `BuyProduct(user, product)`
- [ ] `AddCreditsToAccount(user, amount)`
- [ ] `ExecuteTransaction(transaction)`
- [ ] `GetProductByID(...)`
- [ ] `GetUsers(Func<User, bool> predicate)`
- [ ] `GetUserByUsername(string username)`
- [ ] `GetTransactions(User user, int count)`
- [ ] `ActiveProducts`
