using System;
using Gameplay.Isles.Axis.Events;
using Gameplay.Isles.Axis.Model;
using Gameplay.Isles.Base.Controller;
using Il2CppDummyDll;

namespace Gameplay.Isles.Axis.Controller
{
	// Token: 0x02000D09 RID: 3337
	[Token(Token = "0x2000D09")]
	public class AxisIsleController : BaseIsleController<AxisIsleModel, AxisIsleEvents>
	{
		// Token: 0x0600516A RID: 20842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x9F49", Offset = "0x9F49", VA = "0x9F49")]
		public AxisIsleController(AxisIsleModel model, AxisIsleEvents events)
		{
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x9F4A", Offset = "0x9F4A", VA = "0x9F4A", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x9F4B", Offset = "0x9F4B", VA = "0x9F4B", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x9F4C", Offset = "0x9F4C", VA = "0x9F4C")]
		private void ScheduleChangedEventHandler()
		{
		}
	}
}
