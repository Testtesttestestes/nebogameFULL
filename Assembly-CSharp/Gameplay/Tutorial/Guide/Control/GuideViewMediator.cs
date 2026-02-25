using System;
using System.Collections;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tutorial.Guide.Control
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	public class GuideViewMediator : AbstractViewMediator<GuideModel, GuideEvents, GuideController, GuideView>
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x6D19", Offset = "0x6D19", VA = "0x6D19", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x6D1A", Offset = "0x6D1A", VA = "0x6D1A")]
		public GuideViewMediator(GuideModel model, GuideEvents events, GuideController controller)
		{
		}

		// Token: 0x170004D3 RID: 1235
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D3")]
		public override GuideEvents Events
		{
			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x6D1B", Offset = "0x6D1B", VA = "0x6D1B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D4")]
		public override GuideView View
		{
			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x6D1C", Offset = "0x6D1C", VA = "0x6D1C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x6D1D", Offset = "0x6D1D", VA = "0x6D1D")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x6D1E", Offset = "0x6D1E", VA = "0x6D1E")]
		private void HandleDevEditorToolEnabledChangedEvent()
		{
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x6D1F", Offset = "0x6D1F", VA = "0x6D1F")]
		private void HandleCurrentStepChangedEvent(IGuideTarget target, GuideConfig config)
		{
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x6D20", Offset = "0x6D20", VA = "0x6D20")]
		private void ResetView()
		{
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x6D21", Offset = "0x6D21", VA = "0x6D21")]
		private void SetupView()
		{
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x6D22", Offset = "0x6D22", VA = "0x6D22")]
		private void HandleDevEditorToolEnabledChanged()
		{
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x6D23", Offset = "0x6D23", VA = "0x6D23")]
		private void HandleResolveEvent(GuideConfig config)
		{
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x6D24", Offset = "0x6D24", VA = "0x6D24")]
		private void HandleGameContentScaledEvent()
		{
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x6D25", Offset = "0x6D25", VA = "0x6D25")]
		private IEnumerator UpdateViewCoroutine()
		{
			return null;
		}
	}
}
