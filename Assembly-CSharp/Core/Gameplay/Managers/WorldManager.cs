using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.World.Controller;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001181 RID: 4481
	[Token(Token = "0x2001181")]
	public class WorldManager : IGameManager, IBaseManager, IWorldMovementProvider
	{
		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C3")]
		public WorldEngineEvents WorldEngineEvents
		{
			[Token(Token = "0x6006A51")]
			[Address(RVA = "0xB570", Offset = "0xB570", VA = "0xB570")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C4")]
		public WorldControllerEvents Events
		{
			[Token(Token = "0x6006A52")]
			[Address(RVA = "0xB571", Offset = "0xB571", VA = "0xB571")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C5")]
		public WorldController Controller
		{
			[Token(Token = "0x6006A53")]
			[Address(RVA = "0xB572", Offset = "0xB572", VA = "0xB572")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06006A54 RID: 27220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C6")]
		public WorldModel Model
		{
			[Token(Token = "0x6006A54")]
			[Address(RVA = "0xB573", Offset = "0xB573", VA = "0xB573")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002AC RID: 684
		// (add) Token: 0x06006A55 RID: 27221 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A56 RID: 27222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AC")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A55")]
			[Address(RVA = "0xB574", Offset = "0xB574", VA = "0xB574", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A56")]
			[Address(RVA = "0xB575", Offset = "0xB575", VA = "0xB575", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002AD RID: 685
		// (add) Token: 0x06006A57 RID: 27223 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A58 RID: 27224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AD")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A57")]
			[Address(RVA = "0xB576", Offset = "0xB576", VA = "0xB576", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A58")]
			[Address(RVA = "0xB577", Offset = "0xB577", VA = "0xB577", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A59")]
		[Address(RVA = "0xB578", Offset = "0xB578", VA = "0xB578", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0xB579", Offset = "0xB579", VA = "0xB579", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0xB57A", Offset = "0xB57A", VA = "0xB57A")]
		private void InitMvc()
		{
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0xB57B", Offset = "0xB57B", VA = "0xB57B")]
		private void ControllerOnInitComplete()
		{
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0xB57C", Offset = "0xB57C", VA = "0xB57C")]
		public bool TryAttackMonsterFromCurrentIsle([NotNull] MonsterData monster)
		{
			return default(bool);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0xB57D", Offset = "0xB57D", VA = "0xB57D")]
		public void KickMonsterFromCurrentIsle()
		{
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0xB57E", Offset = "0xB57E", VA = "0xB57E")]
		public bool TryRequestMonsterForCurrentUserIsle()
		{
			return default(bool);
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A60")]
		[Address(RVA = "0xB57F", Offset = "0xB57F", VA = "0xB57F")]
		public void GoHome()
		{
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A61")]
		[Address(RVA = "0xB580", Offset = "0xB580", VA = "0xB580")]
		public void GoToUserIsleById(ulong ownerId)
		{
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A62")]
		[Address(RVA = "0xB581", Offset = "0xB581", VA = "0xB581")]
		public void GoToClanIsleById(ulong clanId)
		{
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A63")]
		[Address(RVA = "0xB582", Offset = "0xB582", VA = "0xB582")]
		public void GoToAxisIsle()
		{
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06006A64 RID: 27236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C7")]
		public string Name
		{
			[Token(Token = "0x6006A64")]
			[Address(RVA = "0xB583", Offset = "0xB583", VA = "0xB583", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06006A65 RID: 27237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C8")]
		public IUserIslesWorldMovement UserIslesWorldMovement
		{
			[Token(Token = "0x6006A65")]
			[Address(RVA = "0xB584", Offset = "0xB584", VA = "0xB584", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06006A66 RID: 27238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C9")]
		public IClanIslesWorldMovement ClanIslesWorldMovement
		{
			[Token(Token = "0x6006A66")]
			[Address(RVA = "0xB585", Offset = "0xB585", VA = "0xB585", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A67")]
		[Address(RVA = "0xB586", Offset = "0xB586", VA = "0xB586")]
		public WorldManager()
		{
		}

		// Token: 0x04003845 RID: 14405
		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x8")]
		private WorldEngineEvents _worldEngineEvents;

		// Token: 0x04003847 RID: 14407
		[Token(Token = "0x4003847")]
		[FieldOffset(Offset = "0x10")]
		private WorldController _controller;

		// Token: 0x04003848 RID: 14408
		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x14")]
		private WorldModel _model;
	}
}
