#region

using Hearthstone_Deck_Tracker.Enums;
using Hearthstone_Deck_Tracker.Enums.Hearthstone;
using Hearthstone_Deck_Tracker.Hearthstone.Entities;

#endregion

namespace Hearthstone_Deck_Tracker
{
	public interface IGameHandler
	{
		void HandlePlayerGet(Entity entity, string cardId, int turn);
		void HandlePlayerBackToHand(Entity entity, string cardId, int turn);
		void HandlePlayerDraw(Entity entity, string cardId, int turn);
		void HandlePlayerMulligan(Entity entity, string cardId);
		void HandlePlayerSecretPlayed(Entity entity, string cardId, int turn, bool fromDeck);
		void HandlePlayerHandDiscard(Entity entity, string cardId, int turn);
		void HandlePlayerPlay(Entity entity, string cardId, int turn);
		void HandlePlayerDeckDiscard(Entity entity, string cardId, int turn);
		void HandlePlayerPlayToDeck(Entity entity, string cardId, int turn);
        void HandlePlayerHeroPower(string cardId, int turn);
        void SetPlayerHero(string playerHero);
		void HandlePlayerName(string name);
		void HandlePlayerGetToDeck(Entity entity, string cardId, int turn);
		void TurnStart(ActivePlayer player, int turnNumber);
		void HandleGameStart();
		void HandleGameEnd();
		void HandleLoss();
		void HandleWin();
		void HandleTied();
		void ResetConstructedImporting();
		void HandlePossibleConstructedCard(string id, bool canBeDoneImporting);
		void HandlePossibleArenaCard(string id);
		void SetGameMode(GameMode mode);
		void HandleInMenu();
		void HandleConcede();
		void HandlePlayerFatigue(int currentDamage);
		void HandleOpponentFatigue(int currentDamage);
		void SetRank(int rank);
		void HandleDustReward(int amount);
		void HandleGoldReward(int amount);

        #region SecretTriggers

        void HandlePlayerAttack(Entity source, Entity target);
	    void HandleAttackingEntity(Entity entity);
	    void HandleDefendingEntity(Entity entity);
        void HandlePlayerMinionPlayed();
        void HandlePlayerSpellPlayed(bool isMinionTargeted);
        void HandlePlayerMinionDeath();
        void HandleOpponentDamage(Entity entity);
        void HandleOpponentTurnStart(Entity entity);

        #endregion

        #region OpponentHandlers

        void HandleOpponentPlay(Entity entity, string cardId, int from, int turn);
		void HandleOpponentHandDiscard(Entity entity, string cardId, int from, int turn);
		void HandleOpponentDraw(Entity entity, int turn);
		void HandleOpponentMulligan(Entity entity, int from);
		void HandleOpponentGet(Entity entity, int turn, int id);
		void HandleOpponentSecretPlayed(Entity entity, string cardId, int from, int turn, bool fromDeck, int otherId);
		void HandleOpponentPlayToHand(Entity entity, string cardId, int turn, int id);
		void HandleOpponentPlayToDeck(Entity entity, string cardId, int turn);
		void HandleOpponentSecretTrigger(Entity entity, string cardId, int turn, int otherId);
		void HandleOpponentDeckDiscard(Entity entity, string cardId, int turn);
		void SetOpponentHero(string hero);
		void HandleOpponentHeroPower(string cardId, int turn);
		void HandleOpponentName(string name);
		void HandleOpponentGetToDeck(Entity entity, int turn);

		#endregion OpponentHandlers

		void HandleOpponentJoust(Entity entity, string cardId, int turn);
		void HandlePlayerPlayToGraveyard(Entity entity, string cardId, int turn);
		void HandleOpponentPlayToGraveyard(Entity entity, string cardId, int turn);
		void HandlePlayerCreateInPlay(Entity entity, string cardId, int turn);
		void HandleOpponentCreateInPlay(Entity entity, string cardId, int turn);
		void HandleZonePositionUpdate(ActivePlayer player, TAG_ZONE tagZone, int turn);
		void HandlePlayerJoust(Entity entity, string cardId, int turn);
		void HandlePlayerDeckToPlay(Entity entity, string cardId, int turn);
		void HandleOpponentDeckToPlay(Entity entity, string cardId, int turn);
		void HandlePlayerRemoveFromDeck(Entity entity, int turn);
		void HandleOpponentRemoveFromDeck(Entity entity, int turn);
	}
}