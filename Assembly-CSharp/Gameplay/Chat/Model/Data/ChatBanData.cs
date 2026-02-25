using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Chat;
using Utils;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class ChatBanData : IDisposable
	{
		// Token: 0x0600444E RID: 17486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x92FE", Offset = "0x92FE", VA = "0x92FE", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x92FF", Offset = "0x92FF", VA = "0x92FF")]
		public ChatBanData(ChatUserInfo.Types.BanInfo banInfo)
		{
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x0000CE10 File Offset: 0x0000B010
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D75")]
		public float FixTime
		{
			[Token(Token = "0x6004450")]
			[Address(RVA = "0x9300", Offset = "0x9300", VA = "0x9300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004451")]
			[Address(RVA = "0x9301", Offset = "0x9301", VA = "0x9301")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004453 RID: 17491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D76")]
		public ChatUserInfo.Types.BanInfo BanInfo
		{
			[Token(Token = "0x6004452")]
			[Address(RVA = "0x9302", Offset = "0x9302", VA = "0x9302")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x9303", Offset = "0x9303", VA = "0x9303")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004455 RID: 17493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D77")]
		public BackTime Backtime
		{
			[Token(Token = "0x6004454")]
			[Address(RVA = "0x9304", Offset = "0x9304", VA = "0x9304")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004455")]
			[Address(RVA = "0x9305", Offset = "0x9305", VA = "0x9305")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x9306", Offset = "0x9306", VA = "0x9306", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
