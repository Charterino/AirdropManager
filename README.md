# AirdropManager - RocketMod5 Plugin
### Configuration
```yml
UseDefaultSpawns: true
UseDefaultAirdrops: false
AirdropMessage: <size=17><color=magenta><i>Airdrop</i> is coming!</color></size>
AirdropMessageIcon: https://i.imgur.com/JCDmlqI.png
AirdropInterval: 3600
Airdrops:
- AirdropId: 1005
  Items:
  - ItemId: 363
    Chance: 10
  - ItemId: 17
    Chance: 20
AirdropSpawns:
- AirdropId: 1005
  Position:
    X: 1
    Y: 1
    Z: 1
BlacklistedAirdrops: []
```

### Translation
```yml
NextAirdrop: Next airdrop will be in {0}!
```