using System;
using System.Runtime.CompilerServices;
using Gameplay.TutorialCombatV2;
using Gameplay.TutorialV2.Events;
using Gameplay.TutorialV2.Model;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	public class TutorialController : AbstractController<TutorialModel, TutorialEvents>
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000484")]
		public TutorialStepsConveyor Conveyor
		{
			[Token(Token = "0x6001980")]
			[Address(RVA = "0x6B1F", Offset = "0x6B1F", VA = "0x6B1F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001981")]
			[Address(RVA = "0x6B20", Offset = "0x6B20", VA = "0x6B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x6B21", Offset = "0x6B21", VA = "0x6B21", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x6B22", Offset = "0x6B22", VA = "0x6B22")]
		public TutorialController(TutorialModel model, TutorialEvents events)
		{
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x6B23", Offset = "0x6B23", VA = "0x6B23")]
		private void ConstructQueue()
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x6B24", Offset = "0x6B24", VA = "0x6B24", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x6B25", Offset = "0x6B25", VA = "0x6B25", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x6B26", Offset = "0x6B26", VA = "0x6B26")]
		private void PrepareData()
		{
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x6B27", Offset = "0x6B27", VA = "0x6B27")]
		private void ValidateInit()
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000485")]
		public TutorialCombat Combat
		{
			[Token(Token = "0x6001989")]
			[Address(RVA = "0x6B28", Offset = "0x6B28", VA = "0x6B28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600198A")]
			[Address(RVA = "0x6B29", Offset = "0x6B29", VA = "0x6B29")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x6B2A", Offset = "0x6B2A", VA = "0x6B2A")]
		private void RequestCombatStart()
		{
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x6B2B", Offset = "0x6B2B", VA = "0x6B2B")]
		private void StartCombat()
		{
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x6B2C", Offset = "0x6B2C", VA = "0x6B2C")]
		private void HandleCombatRequestPrepareView()
		{
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x6B2D", Offset = "0x6B2D", VA = "0x6B2D")]
		private void HandleCombatInitEvent()
		{
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x6B2E", Offset = "0x6B2E", VA = "0x6B2E")]
		private void HandleCombatCompleteEvent()
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x6B2F", Offset = "0x6B2F", VA = "0x6B2F")]
		public void NotifyViewReady()
		{
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x6B30", Offset = "0x6B30", VA = "0x6B30")]
		public void GotoNextState()
		{
		}

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x18")]
		private TutorialService _tutorialService;
	}
}
