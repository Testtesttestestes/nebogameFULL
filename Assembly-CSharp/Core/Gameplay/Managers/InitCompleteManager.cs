using System;
using System.Runtime.CompilerServices;
using Core.Data.User;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001169 RID: 4457
	[Token(Token = "0x2001169")]
	public class InitCompleteManager : IGameManager, IBaseManager, IUserSettings
	{
		// Token: 0x1400028A RID: 650
		// (add) Token: 0x0600693A RID: 26938 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600693B RID: 26939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600693A")]
			[Address(RVA = "0xB45E", Offset = "0xB45E", VA = "0xB45E", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600693B")]
			[Address(RVA = "0xB45F", Offset = "0xB45F", VA = "0xB45F", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400028B RID: 651
		// (add) Token: 0x0600693C RID: 26940 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600693D RID: 26941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600693C")]
			[Address(RVA = "0xB460", Offset = "0xB460", VA = "0xB460", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600693D")]
			[Address(RVA = "0xB461", Offset = "0xB461", VA = "0xB461", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600693F RID: 26943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001588")]
		public UserSettings Settings
		{
			[Token(Token = "0x600693E")]
			[Address(RVA = "0xB462", Offset = "0xB462", VA = "0xB462", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600693F")]
			[Address(RVA = "0xB463", Offset = "0xB463", VA = "0xB463")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006940")]
		[Address(RVA = "0xB464", Offset = "0xB464", VA = "0xB464", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006941")]
		[Address(RVA = "0xB465", Offset = "0xB465", VA = "0xB465")]
		private void InitCompleteSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006942")]
		[Address(RVA = "0xB466", Offset = "0xB466", VA = "0xB466", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06006943 RID: 26947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001589")]
		public string Name
		{
			[Token(Token = "0x6006943")]
			[Address(RVA = "0xB467", Offset = "0xB467", VA = "0xB467", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006944")]
		[Address(RVA = "0xB468", Offset = "0xB468", VA = "0xB468", Slot = "12")]
		public void CommitSettings()
		{
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006945")]
		[Address(RVA = "0xB469", Offset = "0xB469", VA = "0xB469")]
		public InitCompleteManager()
		{
		}
	}
}
