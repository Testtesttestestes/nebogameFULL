using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Assistants.Manufacture.Model;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;

namespace Gameplay.Assistants.Manufacture.Control
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000CB2")]
	public class ManufactureAssistRewardsStorageViewMediator : AbstractViewMediator<ManufactureAssistModel, ManufactureAssistantEvents, ManufactureAssistController, ManufactureAssistantRewardStorageWindow>
	{
		// Token: 0x06004F2F RID: 20271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x9D57", Offset = "0x9D57", VA = "0x9D57")]
		public ManufactureAssistRewardsStorageViewMediator(ManufactureAssistModel model, ManufactureAssistantEvents events, ManufactureAssistController controller)
		{
		}

		// Token: 0x1700101B RID: 4123
		// (set) Token: 0x06004F30 RID: 20272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101B")]
		public override ManufactureAssistantEvents Events
		{
			[Token(Token = "0x6004F30")]
			[Address(RVA = "0x9D58", Offset = "0x9D58", VA = "0x9D58", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700101C RID: 4124
		// (set) Token: 0x06004F31 RID: 20273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101C")]
		public override ManufactureAssistantRewardStorageWindow View
		{
			[Token(Token = "0x6004F31")]
			[Address(RVA = "0x9D59", Offset = "0x9D59", VA = "0x9D59", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x9D5A", Offset = "0x9D5A", VA = "0x9D5A")]
		private void HandleSortValueChangedEvent(bool enabled)
		{
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x9D5B", Offset = "0x9D5B", VA = "0x9D5B")]
		private void HandleInChestButtonClickEvent()
		{
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x9D5C", Offset = "0x9D5C", VA = "0x9D5C")]
		private void HandleSellAllDropButtonClickEvent()
		{
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x9D5D", Offset = "0x9D5D", VA = "0x9D5D")]
		private void HandleTakeAllDropButtonClickEvent()
		{
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x9D5E", Offset = "0x9D5E", VA = "0x9D5E")]
		private void HandleDropChangedEvent()
		{
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x9D5F", Offset = "0x9D5F", VA = "0x9D5F")]
		private void SetupView()
		{
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x9D60", Offset = "0x9D60", VA = "0x9D60")]
		private void RenderItems([NotNull] IList<ArtifactData> items)
		{
		}
	}
}
