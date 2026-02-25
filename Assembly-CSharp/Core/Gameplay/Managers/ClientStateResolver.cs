using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Il2CppDummyDll;
using Protocol.Main;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001150 RID: 4432
	[Token(Token = "0x2001150")]
	public class ClientStateResolver : IGameManager, IBaseManager
	{
		// Token: 0x14000273 RID: 627
		// (add) Token: 0x0600686F RID: 26735 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006870 RID: 26736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000273")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600686F")]
			[Address(RVA = "0xB39A", Offset = "0xB39A", VA = "0xB39A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006870")]
			[Address(RVA = "0xB39B", Offset = "0xB39B", VA = "0xB39B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000274 RID: 628
		// (add) Token: 0x06006871 RID: 26737 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006872 RID: 26738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000274")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006871")]
			[Address(RVA = "0xB39C", Offset = "0xB39C", VA = "0xB39C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006872")]
			[Address(RVA = "0xB39D", Offset = "0xB39D", VA = "0xB39D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001563")]
		public string Name
		{
			[Token(Token = "0x6006873")]
			[Address(RVA = "0xB39E", Offset = "0xB39E", VA = "0xB39E", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06006874 RID: 26740 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006875 RID: 26741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001564")]
		public IGame Game
		{
			[Token(Token = "0x6006874")]
			[Address(RVA = "0xB39F", Offset = "0xB39F", VA = "0xB39F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006875")]
			[Address(RVA = "0xB3A0", Offset = "0xB3A0", VA = "0xB3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006876")]
		[Address(RVA = "0xB3A1", Offset = "0xB3A1", VA = "0xB3A1")]
		public ClientStateResolver(IGame game)
		{
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006877")]
		[Address(RVA = "0xB3A2", Offset = "0xB3A2", VA = "0xB3A2")]
		private void HandleClientStateChanged(ProtoGetClientStateAns state)
		{
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006878")]
		[Address(RVA = "0xB3A3", Offset = "0xB3A3", VA = "0xB3A3", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006879")]
		[Address(RVA = "0xB3A4", Offset = "0xB3A4", VA = "0xB3A4")]
		private void SceneManagerOnSceneUnloadedEvent(string obj)
		{
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687A")]
		[Address(RVA = "0xB3A5", Offset = "0xB3A5", VA = "0xB3A5", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687B")]
		[Address(RVA = "0xB3A6", Offset = "0xB3A6", VA = "0xB3A6")]
		private void SceneManagerOnSceneLoaded(string sceneName)
		{
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687C")]
		[Address(RVA = "0xB3A7", Offset = "0xB3A7", VA = "0xB3A7")]
		private void ClientStateChangedEventHandler(ProtoGetClientStateAns fromState, ProtoGetClientStateAns toState)
		{
		}

		// Token: 0x04003796 RID: 14230
		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<ClientStates> _statesForWorldScene;

		// Token: 0x04003797 RID: 14231
		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x14")]
		private readonly ClientStateResolver.AvailHandlerConfig[] _availClientStateHandlers;

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x18")]
		private Scenes[] _scenesToLoad;

		// Token: 0x02001151 RID: 4433
		[Token(Token = "0x2001151")]
		private interface IClientStateHandler
		{
			// Token: 0x0600687D RID: 26749
			[Token(Token = "0x600687D")]
			void Handle(IGame game, ProtoGetClientStateAns state);
		}

		// Token: 0x02001152 RID: 4434
		[Token(Token = "0x2001152")]
		private class AvailHandlerConfig
		{
			// Token: 0x0600687E RID: 26750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600687E")]
			[Address(RVA = "0xB3A8", Offset = "0xB3A8", VA = "0xB3A8")]
			public AvailHandlerConfig(ClientStates[] states, Type typeOfHandler)
			{
			}

			// Token: 0x0400379A RID: 14234
			[Token(Token = "0x400379A")]
			[FieldOffset(Offset = "0x8")]
			public readonly ClientStates[] States;

			// Token: 0x0400379B RID: 14235
			[Token(Token = "0x400379B")]
			[FieldOffset(Offset = "0xC")]
			public readonly Type TypeOfHandler;
		}

		// Token: 0x02001153 RID: 4435
		[Token(Token = "0x2001153")]
		private class CombatStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x0600687F RID: 26751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600687F")]
			[Address(RVA = "0xB3A9", Offset = "0xB3A9", VA = "0xB3A9", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006880 RID: 26752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006880")]
			[Address(RVA = "0xB3AA", Offset = "0xB3AA", VA = "0xB3AA")]
			public CombatStateHandler()
			{
			}
		}

		// Token: 0x02001154 RID: 4436
		[Token(Token = "0x2001154")]
		private class ThemeDuelStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006881 RID: 26753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006881")]
			[Address(RVA = "0xB3AB", Offset = "0xB3AB", VA = "0xB3AB", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006882 RID: 26754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006882")]
			[Address(RVA = "0xB3AC", Offset = "0xB3AC", VA = "0xB3AC")]
			public ThemeDuelStateHandler()
			{
			}
		}

		// Token: 0x02001155 RID: 4437
		[Token(Token = "0x2001155")]
		private class PortalCombatStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006883 RID: 26755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006883")]
			[Address(RVA = "0xB3AD", Offset = "0xB3AD", VA = "0xB3AD", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006884 RID: 26756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006884")]
			[Address(RVA = "0xB3AE", Offset = "0xB3AE", VA = "0xB3AE")]
			public PortalCombatStateHandler()
			{
			}
		}

		// Token: 0x02001156 RID: 4438
		[Token(Token = "0x2001156")]
		private class ColossusCombatHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006885 RID: 26757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006885")]
			[Address(RVA = "0xB3AF", Offset = "0xB3AF", VA = "0xB3AF", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006886 RID: 26758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006886")]
			[Address(RVA = "0xB3B0", Offset = "0xB3B0", VA = "0xB3B0")]
			public ColossusCombatHandler()
			{
			}
		}

		// Token: 0x02001157 RID: 4439
		[Token(Token = "0x2001157")]
		private class PartyCombatHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006887 RID: 26759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006887")]
			[Address(RVA = "0xB3B1", Offset = "0xB3B1", VA = "0xB3B1", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006888 RID: 26760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006888")]
			[Address(RVA = "0xB3B2", Offset = "0xB3B2", VA = "0xB3B2")]
			public PartyCombatHandler()
			{
			}
		}

		// Token: 0x02001158 RID: 4440
		[Token(Token = "0x2001158")]
		private class AdeptsTournamentStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006889 RID: 26761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006889")]
			[Address(RVA = "0xB3B3", Offset = "0xB3B3", VA = "0xB3B3", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x0600688A RID: 26762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688A")]
			[Address(RVA = "0xB3B4", Offset = "0xB3B4", VA = "0xB3B4")]
			public AdeptsTournamentStateHandler()
			{
			}
		}

		// Token: 0x02001159 RID: 4441
		[Token(Token = "0x2001159")]
		private class GladiatorsTournamentStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x0600688B RID: 26763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688B")]
			[Address(RVA = "0xB3B5", Offset = "0xB3B5", VA = "0xB3B5", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x0600688C RID: 26764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688C")]
			[Address(RVA = "0xB3B6", Offset = "0xB3B6", VA = "0xB3B6")]
			public GladiatorsTournamentStateHandler()
			{
			}
		}

		// Token: 0x0200115A RID: 4442
		[Token(Token = "0x200115A")]
		private class HordeStateHandler : ClientStateResolver.IClientStateHandler, IDisposable
		{
			// Token: 0x0600688D RID: 26765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688D")]
			[Address(RVA = "0xB3B7", Offset = "0xB3B7", VA = "0xB3B7", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x0600688E RID: 26766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688E")]
			[Address(RVA = "0xB3B8", Offset = "0xB3B8", VA = "0xB3B8")]
			private void CurrentIsleChangedEventHandler(ulong userId)
			{
			}

			// Token: 0x0600688F RID: 26767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688F")]
			[Address(RVA = "0xB3B9", Offset = "0xB3B9", VA = "0xB3B9", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x06006890 RID: 26768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006890")]
			[Address(RVA = "0xB3BA", Offset = "0xB3BA", VA = "0xB3BA")]
			public HordeStateHandler()
			{
			}

			// Token: 0x0400379C RID: 14236
			[Token(Token = "0x400379C")]
			[FieldOffset(Offset = "0x8")]
			private IGame _game;
		}

		// Token: 0x0200115B RID: 4443
		[Token(Token = "0x200115B")]
		private class DuelStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006891 RID: 26769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006891")]
			[Address(RVA = "0xB3BB", Offset = "0xB3BB", VA = "0xB3BB", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006892 RID: 26770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006892")]
			[Address(RVA = "0xB3BC", Offset = "0xB3BC", VA = "0xB3BC")]
			public DuelStateHandler()
			{
			}
		}

		// Token: 0x0200115C RID: 4444
		[Token(Token = "0x200115C")]
		private class WaitingForMinionBattleStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006893 RID: 26771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006893")]
			[Address(RVA = "0xB3BD", Offset = "0xB3BD", VA = "0xB3BD", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006894 RID: 26772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006894")]
			[Address(RVA = "0xB3BE", Offset = "0xB3BE", VA = "0xB3BE")]
			public WaitingForMinionBattleStateHandler()
			{
			}
		}

		// Token: 0x0200115D RID: 4445
		[Token(Token = "0x200115D")]
		private class IdleStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006895 RID: 26773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006895")]
			[Address(RVA = "0xB3BF", Offset = "0xB3BF", VA = "0xB3BF", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006896 RID: 26774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006896")]
			[Address(RVA = "0xB3C0", Offset = "0xB3C0", VA = "0xB3C0")]
			public IdleStateHandler()
			{
			}
		}
	}
}
