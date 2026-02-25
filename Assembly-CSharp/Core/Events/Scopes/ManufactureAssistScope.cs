using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001011 RID: 4113
	[Token(Token = "0x2001011")]
	public class ManufactureAssistScope : AbstractEventBusScope
	{
		// Token: 0x06006161 RID: 24929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006161")]
		[Address(RVA = "0xAD8C", Offset = "0xAD8C", VA = "0xAD8C", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006162")]
		[Address(RVA = "0xAD8D", Offset = "0xAD8D", VA = "0xAD8D")]
		public ManufactureAssistScope()
		{
		}

		// Token: 0x0400343C RID: 13372
		[Token(Token = "0x400343C")]
		[FieldOffset(Offset = "0x8")]
		public Action<ManufactureAssistScope.ManufactureAssistEventArgs> DismantleStartEvent;

		// Token: 0x02001012 RID: 4114
		[Token(Token = "0x2001012")]
		public class ManufactureAssistEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700134F RID: 4943
			// (get) Token: 0x06006163 RID: 24931 RVA: 0x00011CD0 File Offset: 0x0000FED0
			[Token(Token = "0x1700134F")]
			public uint StackSize
			{
				[Token(Token = "0x6006163")]
				[Address(RVA = "0xAD8E", Offset = "0xAD8E", VA = "0xAD8E")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06006164 RID: 24932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006164")]
			[Address(RVA = "0xAD8F", Offset = "0xAD8F", VA = "0xAD8F")]
			public ManufactureAssistEventArgs(App app, IGame game, uint stackSize)
			{
			}
		}
	}
}
