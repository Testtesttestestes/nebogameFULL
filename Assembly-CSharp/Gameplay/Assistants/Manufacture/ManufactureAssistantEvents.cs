using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.Assistants.Manufacture
{
	// Token: 0x02000CAA RID: 3242
	[Token(Token = "0x2000CAA")]
	public class ManufactureAssistantEvents : AbstractMVCEvents
	{
		// Token: 0x06004EE3 RID: 20195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x9D0B", Offset = "0x9D0B", VA = "0x9D0B")]
		public ManufactureAssistantEvents()
		{
		}

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x14")]
		public Action DismantleStatusChangedEvent;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x18")]
		public Action InfoChangedEvent;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x1C")]
		public Action DropChangedEvent;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x20")]
		public Action<ArtifactInfo> DismantleSlotsChangedEvent;
	}
}
