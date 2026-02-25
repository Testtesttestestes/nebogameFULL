using System;
using System.Collections;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Tutorial.Guide.Control
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	public class GuideController : AbstractController<GuideModel, GuideEvents>
	{
		// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x6CFE", Offset = "0x6CFE", VA = "0x6CFE", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x6CFF", Offset = "0x6CFF", VA = "0x6CFF")]
		public GuideController(GuideModel model, GuideEvents events)
		{
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x6D00", Offset = "0x6D00", VA = "0x6D00", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x6D01", Offset = "0x6D01", VA = "0x6D01", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x6D02", Offset = "0x6D02", VA = "0x6D02")]
		public void RunTutorial(uint tutorialId)
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x6D03", Offset = "0x6D03", VA = "0x6D03")]
		public bool TryStopCurrentTutorial()
		{
			return default(bool);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x6D04", Offset = "0x6D04", VA = "0x6D04")]
		public void SetCurrent(IGuideTarget target, GuideConfig config)
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x6D05", Offset = "0x6D05", VA = "0x6D05")]
		public bool TryAdd(IGuideTarget target)
		{
			return default(bool);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x6D06", Offset = "0x6D06", VA = "0x6D06")]
		public bool TryRemove(IGuideTarget target)
		{
			return default(bool);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x6D07", Offset = "0x6D07", VA = "0x6D07")]
		private void TryDelayedDefineNext()
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x6D08", Offset = "0x6D08", VA = "0x6D08")]
		private void SetNextStep()
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x6D09", Offset = "0x6D09", VA = "0x6D09")]
		private bool TryStartNextTutorial()
		{
			return default(bool);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x6D0A", Offset = "0x6D0A", VA = "0x6D0A")]
		private void DefineNext()
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x6D0B", Offset = "0x6D0B", VA = "0x6D0B")]
		private bool CheckRestrictions(GuideConfig config)
		{
			return default(bool);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x6D0C", Offset = "0x6D0C", VA = "0x6D0C")]
		public IEnumerator WaitEndOfFrameCoroutine()
		{
			return null;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x6D0D", Offset = "0x6D0D", VA = "0x6D0D")]
		private void HandleLogTutorialStep(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x6D0E", Offset = "0x6D0E", VA = "0x6D0E")]
		public void NotifyAboutViewReady()
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x6D0F", Offset = "0x6D0F", VA = "0x6D0F")]
		public void Resolve(GuideConfig config)
		{
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x6D10", Offset = "0x6D10", VA = "0x6D10")]
		public void DevEditorToolEnable(bool value)
		{
		}

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x18")]
		private TutorialService _service;

		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x1C")]
		private RequirementsManager _requirementsManager;

		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x20")]
		private readonly TutorialGuideObserver _tutorialGuideObserver;

		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _waitEndOfFrameCoroutine;
	}
}
