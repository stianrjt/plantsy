# plantsy
Plantsy plant manager

# Deploy to Heroku: 
1. move dockerfile to solutionfolder(instead of projectFolder) --> visual studio runs dockerfile from solution directory
2. heroku container:login
3. heroku container:push web -a plantsy-no
4. heroku container:release web -a plantsy-no
5. heroku logs --tail -a plantsy-no

## Remove authentication
## Use Sqlite
