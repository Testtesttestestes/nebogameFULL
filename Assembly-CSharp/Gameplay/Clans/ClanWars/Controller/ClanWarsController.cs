using System;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.ClanWars.Controller
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	public class ClanWarsController : AbstractController<ClanWarsModel, ClanWarsEvents>
	{
		// Token: 0x060041C3 RID: 16835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x9077", Offset = "0x9077", VA = "0x9077")]
		public ClanWarsController(ClanWarsModel model, ClanWarsEvents events)
		{
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0x9078", Offset = "0x9078", VA = "0x9078", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C5")]
		[Address(RVA = "0x9079", Offset = "0x9079", VA = "0x9079", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C6")]
		[Address(RVA = "0x907A", Offset = "0x907A", VA = "0x907A")]
		private void SeasonStartedEventHandler(ProtoSeasonStartedEvt evt)
		{
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C7")]
		[Address(RVA = "0x907B", Offset = "0x907B", VA = "0x907B")]
		public void RequestUpdateActiveWar()
		{
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C8")]
		[Address(RVA = "0x907C", Offset = "0x907C", VA = "0x907C")]
		private void GetActiveWarInfo()
		{
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C9")]
		[Address(RVA = "0x907D", Offset = "0x907D", VA = "0x907D")]
		private void GetActiveWarInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CA")]
		[Address(RVA = "0x907E", Offset = "0x907E", VA = "0x907E")]
		public void GetCurrentSeasonInfo()
		{
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CB")]
		[Address(RVA = "0x907F", Offset = "0x907F", VA = "0x907F")]
		private void GetCurrentSeasonInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0x9080", Offset = "0x9080", VA = "0x9080")]
		public void TakeOutGolem(ResourceSet price)
		{
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0x9081", Offset = "0x9081", VA = "0x9081")]
		private void TakeOutGolemResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CE")]
		[Address(RVA = "0x9082", Offset = "0x9082", VA = "0x9082")]
		public void RepairGolem(ResourceSet price)
		{
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CF")]
		[Address(RVA = "0x9083", Offset = "0x9083", VA = "0x9083")]
		private void RepairGolemResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D0")]
		[Address(RVA = "0x9084", Offset = "0x9084", VA = "0x9084")]
		public void DeclareWar(ulong clanId, ResourceSet price, string clanName)
		{
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D1")]
		[Address(RVA = "0x9085", Offset = "0x9085", VA = "0x9085")]
		private void DeclareWarResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D2")]
		[Address(RVA = "0x9086", Offset = "0x9086", VA = "0x9086")]
		public void PayOff()
		{
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D3")]
		[Address(RVA = "0x9087", Offset = "0x9087", VA = "0x9087")]
		private void PayOffResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D4")]
		[Address(RVA = "0x9088", Offset = "0x9088", VA = "0x9088")]
		public void AccelerateWarPreparation()
		{
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D5")]
		[Address(RVA = "0x9089", Offset = "0x9089", VA = "0x9089")]
		private void AccelerateWarPreparationResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0x908A", Offset = "0x908A", VA = "0x908A")]
		public void CancelAcceleration()
		{
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D7")]
		[Address(RVA = "0x908B", Offset = "0x908B", VA = "0x908B")]
		private void CancelAccelerationResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D8")]
		[Address(RVA = "0x908C", Offset = "0x908C", VA = "0x908C")]
		private void WarStateChangedEventHandler(ProtoWarStateChangedEvt evt)
		{
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0x908D", Offset = "0x908D", VA = "0x908D")]
		private void NewWarDeclaredEventHandler(ProtoNewWarDeclaredEvt evt)
		{
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x908E", Offset = "0x908E", VA = "0x908E")]
		private void ClanWarCompletedEventHandler(ProtoClanWarCompleteEvt evt)
		{
		}

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarsService _clanWarsService;
	}
}
