﻿module GLSManager.GlobalGLSState

open GLSCore.PartyCharacter
open GLSCore.GameMap
 
type GameMode = 
    | Easy
    | Moderate 
    | Hard 

type ActivationMode = 
    | On 
    | Off

type GameOptions = 
    | ModifyVolume
    | VibrateMode of ActivationMode
    | ModifyGameMode of GameMode

type Storyline = 
    | GameMechanicsIntroduction 
    | Prelude
    | FirstBattle 
    | LostCityOfBaltazaar
    | ImpenetrableFortressOfBarbas
    | KaltheasRiver
    | BeyondLostWoods

type MenuOptions =
    | SelectOpenRecentGame
    | SelectSavedFiles
    | SelectOptions

type GLSPlayer = { 
    Username : string 
    BestCharacter : PartyCharacter
}

type MenuState = {
    SelectedMenuOption : MenuOptions
    Player             : GLSPlayer
}

type BattlePhase = 
    | Move
    | EngageCharacter
    | EndTurn

type BattleSequenceState = {
    ActivePhase     : BattlePhase
    PlayerTeamParty : PartyCharacter array
    BrainTeamParty  : PartyCharacter array
    Board           : GameBoard
}

// Basic implementation of the weapon & item store 
// Will be move later. 
type WeaponStore = {
    RustedSword : string
    BattleAxe : string
    RustedHelm : string 
    RustedArmor : string 
    RustedShield : string 
    CheapMagicWand : string 
}
with 
    member x.selectWeapon(weapon: string) =     
        weapon
    member x.sellWeapon(weapon: string) = 
        ()

type ItemStore = {
    HealthPotion : string
    MagicPotion : string 
    PhoenixFeather : string
}

type WeaponStoreState = {
    Store : WeaponStore    
}

type ItemStoreState = {
    Store: ItemStore
}

type GlobalGameState = {
    Menu : MenuState
    Story : Storyline
    BattleSequence : BattleSequenceState
    ItemStore : ItemStoreState
    WeaponStore : WeaponStoreState
}