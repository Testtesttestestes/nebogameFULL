using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Balance;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public class BalanceService : AbstractService
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x17000092")]
		public override short ServiceId
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x581C", Offset = "0x581C", VA = "0x581C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000016")]
		public event Action<ProtoResourcesChangedEvt> BalanceChangedEvent
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x581D", Offset = "0x581D", VA = "0x581D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x581E", Offset = "0x581E", VA = "0x581E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000017")]
		public event Action<double> ExternalMoneyChangedEvent
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x581F", Offset = "0x581F", VA = "0x581F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x5820", Offset = "0x5820", VA = "0x5820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x5821", Offset = "0x5821", VA = "0x5821", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x5822", Offset = "0x5822", VA = "0x5822")]
		public OpToken<IMessage, object> GetUserBalance()
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5823", Offset = "0x5823", VA = "0x5823")]
		public OpToken<IMessage, object> GetEnergyRegenStatus()
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5824", Offset = "0x5824", VA = "0x5824")]
		public void ChangeBalance(ProtoResourcesChangedEvt value)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5825", Offset = "0x5825", VA = "0x5825")]
		public BalanceService()
		{
		}
	}
}
