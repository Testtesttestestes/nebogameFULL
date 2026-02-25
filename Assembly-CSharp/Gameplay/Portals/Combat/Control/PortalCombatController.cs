using System;
using Gameplay.Combat.Control;
using Gameplay.Portals.Combat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Combat.Control
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	public class PortalCombatController : CombatController<PortalCombatModel, PortalCombatEvents>
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x7618", Offset = "0x7618", VA = "0x7618")]
		public PortalCombatController(ICombatService service, PortalsService portalsService, PortalCombatModel model, PortalCombatEvents events)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x7619", Offset = "0x7619", VA = "0x7619", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x761A", Offset = "0x761A", VA = "0x761A", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x761B", Offset = "0x761B", VA = "0x761B")]
		private void InfoChangedHandler()
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x761C", Offset = "0x761C", VA = "0x761C")]
		private void OnDropRemoveEventHandler(DropTypes obDropType)
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0x761D", Offset = "0x761D", VA = "0x761D")]
		private void HandleRequestCombatService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x761E", Offset = "0x761E", VA = "0x761E", Slot = "20")]
		protected override bool TryHandleJoinError(ProtoJoinToCombatAns msg)
		{
			return default(bool);
		}

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x20")]
		private readonly PortalsService _portalsService;
	}
}
