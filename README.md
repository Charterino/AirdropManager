# AirdropManager - RocketMod5 Plugin
* Plugin is available in both RocketMod 4 and 5 versions
* Allows you to create airdrops with custom loot
* Allows you to create targets for airdrops or you can use default
* Allows you to set up ChatMaster like message (with size, colors, style and icon)
* Allows you to blacklist unwanted airdrops by id

## Commands
* /airdrop - Calls in an airdrop
* /whenairdrop - Shows time left to next airdrop
* /setairdrop \<airdrop id\> - Saves you current position as airdrop target

## Configuration
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

## Translation
```yml
NextAirdrop: Next airdrop will be in {0}!
```