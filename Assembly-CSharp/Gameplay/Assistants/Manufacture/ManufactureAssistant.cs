using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Manufacture.Control;
using Gameplay.Assistants.Manufacture.Model;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Assistants.Manufacture
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	public class ManufactureAssistant : Assistant<ManufactureAssistModel>
	{
		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FFC")]
		public ManufactureAssistController Controller
		{
			[Token(Token = "0x6004EDB")]
			[Address(RVA = "0x9D03", Offset = "0x9D03", VA = "0x9D03")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EDC")]
			[Address(RVA = "0x9D04", Offset = "0x9D04", VA = "0x9D04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FFD")]
		public override ManufactureAssistModel Model
		{
			[Token(Token = "0x6004EDD")]
			[Address(RVA = "0x9D05", Offset = "0x9D05", VA = "0x9D05", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x9D06", Offset = "0x9D06", VA = "0x9D06", Slot = "6")]
		protected override void HandleRun(AssistantStatus status)
		{
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x9D07", Offset = "0x9D07", VA = "0x9D07", Slot = "7")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x9D08", Offset = "0x9D08", VA = "0x9D08", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x9D09", Offset = "0x9D09", VA = "0x9D09")]
		public ManufactureAssistViewInAccountViewMediator CreateMeditor(ManufactureViewInAccountView view)
		{
			return null;
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x9D0A", Offset = "0x9D0A", VA = "0x9D0A")]
		public ManufactureAssistant()
		{
		}

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x18")]
		private ManufactureAssistModel _model;
	}
}
