using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using Protocol.Themeduel;
using Utils;

namespace Gameplay.ThemeDuelState.Model
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	public class ThemeDuelStateModel : AbstractModel
	{
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x1700053C")]
		public bool HasCurrentThemeDuel
		{
			[Token(Token = "0x6001D4A")]
			[Address(RVA = "0x6EC9", Offset = "0x6EC9", VA = "0x6EC9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053D")]
		public ThemeDuelDic CurrentThemeDuel
		{
			[Token(Token = "0x6001D4B")]
			[Address(RVA = "0x6ECA", Offset = "0x6ECA", VA = "0x6ECA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x1700053E")]
		public ThemeRatingTypes ThemeRatingType
		{
			[Token(Token = "0x6001D4C")]
			[Address(RVA = "0x6ECB", Offset = "0x6ECB", VA = "0x6ECB")]
			get
			{
				return ThemeRatingTypes.Unknown;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053F")]
		public BackTime DuelBackTime
		{
			[Token(Token = "0x6001D4D")]
			[Address(RVA = "0x6ECC", Offset = "0x6ECC", VA = "0x6ECC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D4E")]
			[Address(RVA = "0x6ECD", Offset = "0x6ECD", VA = "0x6ECD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000540")]
		public BackTime EventBackTime
		{
			[Token(Token = "0x6001D4F")]
			[Address(RVA = "0x6ECE", Offset = "0x6ECE", VA = "0x6ECE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D50")]
			[Address(RVA = "0x6ECF", Offset = "0x6ECF", VA = "0x6ECF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x17000541")]
		public long EventBalance
		{
			[Token(Token = "0x6001D51")]
			[Address(RVA = "0x6ED0", Offset = "0x6ED0", VA = "0x6ED0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x17000542")]
		public int EventEntryAttempt
		{
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0x6ED1", Offset = "0x6ED1", VA = "0x6ED1")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000543")]
		public ResourceSet Price
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x6ED2", Offset = "0x6ED2", VA = "0x6ED2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x6ED3", Offset = "0x6ED3", VA = "0x6ED3")]
		public ThemeDuelStateModel(UserData user, IGame game)
		{
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x6ED4", Offset = "0x6ED4", VA = "0x6ED4")]
		public void SetCurrentThemeDuel(ThemeduelEventInfo currentState, ThemeDuelStateEvents events)
		{
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x6ED5", Offset = "0x6ED5", VA = "0x6ED5")]
		public void SetEventBalance(long value, ThemeDuelStateEvents events)
		{
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x6ED6", Offset = "0x6ED6", VA = "0x6ED6")]
		public void SetEventEntryAttempt(int value, ThemeDuelStateEvents events)
		{
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x6ED7", Offset = "0x6ED7", VA = "0x6ED7")]
		public bool TryGetCurrentDuel(out ThemeDuelDic dic)
		{
			return default(bool);
		}

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0xC")]
		private readonly IGame _game;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x10")]
		private ThemeDuelDic _currentThemeDuel;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x18")]
		private long? _balance;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x28")]
		private int? _entryAttempt;
	}
}
