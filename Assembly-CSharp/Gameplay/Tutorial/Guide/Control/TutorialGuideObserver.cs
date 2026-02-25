using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.Control
{
	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	public class TutorialGuideObserver : IDisposable
	{
		// Token: 0x06001BAD RID: 7085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x6D2C", Offset = "0x6D2C", VA = "0x6D2C", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x6D2D", Offset = "0x6D2D", VA = "0x6D2D")]
		public void StartTutorial(GuideConfig config)
		{
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x6D2E", Offset = "0x6D2E", VA = "0x6D2E")]
		public void StartStep(GuideConfig config)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x6D2F", Offset = "0x6D2F", VA = "0x6D2F")]
		public void FinishTutorial()
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x6D30", Offset = "0x6D30", VA = "0x6D30")]
		public void FinishStep()
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x6D31", Offset = "0x6D31", VA = "0x6D31")]
		public TutorialGuideObserver()
		{
		}

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x8")]
		[TupleElementNames(new string[]
		{
			"stageId",
			"step"
		})]
		private ValueTuple<string, uint>? _currentStepMeta;
	}
}
