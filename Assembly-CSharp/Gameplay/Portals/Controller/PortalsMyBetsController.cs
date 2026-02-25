using System;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	public class PortalsMyBetsController : AbstractController<PortalsMyBetsModel, PortalsEvents>
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x757B", Offset = "0x757B", VA = "0x757B")]
		public PortalsMyBetsController(PortalsMyBetsModel model, PortalsEvents events, PortalsService portalsService)
		{
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x757C", Offset = "0x757C", VA = "0x757C")]
		public void GetBetsHistory()
		{
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x757D", Offset = "0x757D", VA = "0x757D")]
		private void OnUpdateBetsHistory(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x757E", Offset = "0x757E", VA = "0x757E")]
		public void GetBetList(ulong betId)
		{
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x757F", Offset = "0x757F", VA = "0x757F")]
		private void OnGetBetList(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x18")]
		private PortalsService _portalsService;
	}
}
