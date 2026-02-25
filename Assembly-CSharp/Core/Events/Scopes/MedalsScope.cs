using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001013 RID: 4115
	[Token(Token = "0x2001013")]
	public class MedalsScope : AbstractEventBusScope
	{
		// Token: 0x06006165 RID: 24933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006165")]
		[Address(RVA = "0xAD90", Offset = "0xAD90", VA = "0xAD90", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006166")]
		[Address(RVA = "0xAD91", Offset = "0xAD91", VA = "0xAD91")]
		public MedalsScope()
		{
		}

		// Token: 0x0400343E RID: 13374
		[Token(Token = "0x400343E")]
		[FieldOffset(Offset = "0x8")]
		public Action<MedalsScope.MedalEventArgs> NewMedalEvent;

		// Token: 0x0400343F RID: 13375
		[Token(Token = "0x400343F")]
		[FieldOffset(Offset = "0xC")]
		public Action<MedalsScope.MedalEventArgs> BuyMedalEvent;

		// Token: 0x02001014 RID: 4116
		[Token(Token = "0x2001014")]
		public class MedalEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001350 RID: 4944
			// (get) Token: 0x06006167 RID: 24935 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001350")]
			public MedalData MedalData
			{
				[Token(Token = "0x6006167")]
				[Address(RVA = "0xAD92", Offset = "0xAD92", VA = "0xAD92")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001351 RID: 4945
			// (get) Token: 0x06006168 RID: 24936 RVA: 0x00011CE8 File Offset: 0x0000FEE8
			[Token(Token = "0x17001351")]
			public uint MedalId
			{
				[Token(Token = "0x6006168")]
				[Address(RVA = "0xAD93", Offset = "0xAD93", VA = "0xAD93")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06006169 RID: 24937 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006169")]
			[Address(RVA = "0xAD94", Offset = "0xAD94", VA = "0xAD94")]
			public MedalEventArgs(App app, IGame game, MedalData medalData, uint medalId)
			{
			}
		}
	}
}
