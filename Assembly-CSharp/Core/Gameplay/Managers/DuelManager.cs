using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Duel.Controller;
using Gameplay.Duel.Events;
using Gameplay.Duel.Model;
using Gameplay.Duel.View;
using Il2CppDummyDll;
using Protocol.Duel;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001165 RID: 4453
	[Token(Token = "0x2001165")]
	public class DuelManager : IGameManager, IBaseManager
	{
		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06006908 RID: 26888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001580")]
		public string Name
		{
			[Token(Token = "0x6006908")]
			[Address(RVA = "0xB42C", Offset = "0xB42C", VA = "0xB42C", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000282 RID: 642
		// (add) Token: 0x06006909 RID: 26889 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600690A RID: 26890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000282")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006909")]
			[Address(RVA = "0xB42D", Offset = "0xB42D", VA = "0xB42D", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600690A")]
			[Address(RVA = "0xB42E", Offset = "0xB42E", VA = "0xB42E", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000283 RID: 643
		// (add) Token: 0x0600690B RID: 26891 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600690C RID: 26892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000283")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600690B")]
			[Address(RVA = "0xB42F", Offset = "0xB42F", VA = "0xB42F", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600690C")]
			[Address(RVA = "0xB430", Offset = "0xB430", VA = "0xB430", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x0600690D RID: 26893 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600690E RID: 26894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001581")]
		public DuelController Controller
		{
			[Token(Token = "0x600690D")]
			[Address(RVA = "0xB431", Offset = "0xB431", VA = "0xB431")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600690E")]
			[Address(RVA = "0xB432", Offset = "0xB432", VA = "0xB432")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600690F")]
		[Address(RVA = "0xB433", Offset = "0xB433", VA = "0xB433", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006910")]
		[Address(RVA = "0xB434", Offset = "0xB434", VA = "0xB434", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006911")]
		[Address(RVA = "0xB435", Offset = "0xB435", VA = "0xB435")]
		public void ShowDuelWindow(UserData opponent)
		{
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006912")]
		[Address(RVA = "0xB436", Offset = "0xB436", VA = "0xB436")]
		public void ShowDuelWindow(DuelStateInfo state)
		{
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006913")]
		[Address(RVA = "0xB437", Offset = "0xB437", VA = "0xB437")]
		private void GetUserDataResultHandler(long operationIndex, UserData[] data)
		{
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006914")]
		[Address(RVA = "0xB438", Offset = "0xB438", VA = "0xB438")]
		public void StartCombat()
		{
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006915")]
		[Address(RVA = "0xB439", Offset = "0xB439", VA = "0xB439")]
		public DuelManager()
		{
		}

		// Token: 0x040037C5 RID: 14277
		[Token(Token = "0x40037C5")]
		[FieldOffset(Offset = "0x10")]
		private DuelModel _model;

		// Token: 0x040037C6 RID: 14278
		[Token(Token = "0x40037C6")]
		[FieldOffset(Offset = "0x14")]
		private Gameplay.Duel.Events.DuelEvents _events;

		// Token: 0x040037C7 RID: 14279
		[Token(Token = "0x40037C7")]
		[FieldOffset(Offset = "0x18")]
		private DuelWindow _view;
	}
}
