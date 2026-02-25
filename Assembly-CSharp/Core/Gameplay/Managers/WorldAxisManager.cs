using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.WorldAxis.Colossus.Combat;
using Gameplay.WorldAxis.Controller;
using Gameplay.WorldAxis.Events;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001180 RID: 4480
	[Token(Token = "0x2001180")]
	public class WorldAxisManager : IGameManager, IBaseManager
	{
		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015BC")]
		public string Name
		{
			[Token(Token = "0x6006A3C")]
			[Address(RVA = "0xB55B", Offset = "0xB55B", VA = "0xB55B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002AA RID: 682
		// (add) Token: 0x06006A3D RID: 27197 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A3E RID: 27198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AA")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A3D")]
			[Address(RVA = "0xB55C", Offset = "0xB55C", VA = "0xB55C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A3E")]
			[Address(RVA = "0xB55D", Offset = "0xB55D", VA = "0xB55D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002AB RID: 683
		// (add) Token: 0x06006A3F RID: 27199 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A40 RID: 27200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AB")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A3F")]
			[Address(RVA = "0xB55E", Offset = "0xB55E", VA = "0xB55E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A40")]
			[Address(RVA = "0xB55F", Offset = "0xB55F", VA = "0xB55F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015BD")]
		public IGame Game
		{
			[Token(Token = "0x6006A41")]
			[Address(RVA = "0xB560", Offset = "0xB560", VA = "0xB560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A42")]
			[Address(RVA = "0xB561", Offset = "0xB561", VA = "0xB561")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06006A43 RID: 27203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A44 RID: 27204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015BE")]
		public WorldAxisModel Model
		{
			[Token(Token = "0x6006A43")]
			[Address(RVA = "0xB562", Offset = "0xB562", VA = "0xB562")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A44")]
			[Address(RVA = "0xB563", Offset = "0xB563", VA = "0xB563")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015BF")]
		public WorldAxisEvents Events
		{
			[Token(Token = "0x6006A45")]
			[Address(RVA = "0xB564", Offset = "0xB564", VA = "0xB564")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A46")]
			[Address(RVA = "0xB565", Offset = "0xB565", VA = "0xB565")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015C0")]
		public WorldAxisController Controller
		{
			[Token(Token = "0x6006A47")]
			[Address(RVA = "0xB566", Offset = "0xB566", VA = "0xB566")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A48")]
			[Address(RVA = "0xB567", Offset = "0xB567", VA = "0xB567")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C1")]
		public ResourceSet AttackPrice
		{
			[Token(Token = "0x6006A49")]
			[Address(RVA = "0xB568", Offset = "0xB568", VA = "0xB568")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06006A4A RID: 27210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C2")]
		public ResourceSet DefencePrice
		{
			[Token(Token = "0x6006A4A")]
			[Address(RVA = "0xB569", Offset = "0xB569", VA = "0xB569")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0xB56A", Offset = "0xB56A", VA = "0xB56A")]
		public WorldAxisManager([NotNull] IGame game)
		{
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4C")]
		[Address(RVA = "0xB56B", Offset = "0xB56B", VA = "0xB56B")]
		public void ShowWorldAxisWindow()
		{
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4D")]
		[Address(RVA = "0xB56C", Offset = "0xB56C", VA = "0xB56C")]
		public void ShowColossusInfoWindow(ColossusBattleData data)
		{
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0xB56D", Offset = "0xB56D", VA = "0xB56D", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0xB56E", Offset = "0xB56E", VA = "0xB56E", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0xB56F", Offset = "0xB56F", VA = "0xB56F")]
		private void InitEventHandler()
		{
		}

		// Token: 0x04003844 RID: 14404
		[Token(Token = "0x4003844")]
		[FieldOffset(Offset = "0x20")]
		private ColossusCombatLauncher _colossusCombatLauncher;
	}
}
