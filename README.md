# CardDataLib for Rogue Tower

CardDataLib loads all 638 base‑game cards into any scene and fixes a large set of data issues the vanilla game has (wrong/missing UnlockNames, broken dependencies, inconsistent titles between MainMenu and GameScene, etc.).

## Installation

    Download the CardDataLib DLL.

    Place the .dll file into your BepInEx/plugins folder.

    Launch the game.

## What it gives you

    All 638 base-game cards available from any scene.

    Missing UnlockNames added and wrong ones fixed.

    Discrepancies fixed between MainMenu and GameScene names.

    Missing dependencies restored, preventing 13 unique cards from being unobtainable.

    Sprite linking via TexturesLib.Shared.SpriteHelper.FindSpriteByName.


## Broken Cards Fixed

The following 3 cards were broken in the base game and blocked entire upgrade paths:

    Toccata and Fugue II (Vampire Lair path)

    Honor II (Monument path)

    Heavy Particles II (Particle Cannon path)

By fixing these, CardDataLib restores the ability to unlock the following cards:

### Vampire Lair Armor Path:

    Toccata and Fugue III

    Gothic Horror

    Monster Studies

    Tower of Blood

    Better Vampires

### Monument Armor Path:

    Honor III

    Martial Prowess

    Monster Studies

    More Hate

### Particle Cannon Armor Path:

    Heavy Particles III

    Quantum Physics

    Monster Studies

    Better Particles

## UnlockName Fixes

    Round Shot I/II/III → CannonArmor1/2/3

    Dark Night I/II/III → VampireLairHealth1/2/3

    Gothic Horror → VampireLairDamage1

    Feast II → VampireLairBleed2

    Seance I/II/III → Seance1/2/3

    Savings Account I/II → Savings1/2

    Scholarships I/II/III → Scholarships1/2/3

    Sorcery I/II/III → Sourcery1/2/3

    Life Steal I/II/III → LifeSteal1/2/3

    Fortification I–IV → TowerHealth1/2/3/4

    Frugal I–VI → Frugal1–6

    Monster Armor I–XX → MonsterArmor1–20

    Monster Health I–XX → MonsterHealth1–20

    Monster Shields I–XX → MonsterShields1–20

    Monster Destruction I–III → MonsterDestruction1–3

    Monster Speed I–XV → MonsterSpeed1–15

    Monster Quickness I–IV → MonsterQuickness1–4

    Monster Perserverance I–VI → MonsterPerserverance1–6

    Monster Protection I–VIII → MonsterProtection1–8

    Gold Rush! → GoldRush

    Research Breakthrough! (University) → Research1/2/3

    Tesla Coil Power Surge III label fixed in Main Menu

## Title Fixes

    Quality over Quantity renamed to Quality over Quantity I.

    Pyrochemistry I–IV renamed to Fuel Saturation I–IV.

    Immolation renamed to Pyrochemistry.

    Fumes I–III renamed to Fumigation I–III.

