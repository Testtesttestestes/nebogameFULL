using System;
using System.Collections;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C6B RID: 3179
	[Token(Token = "0x2000C6B")]
	public class PaymentBonusController : AbstractController<PaymentBonusModel, PaymentBonusEvents>
	{
		// Token: 0x06004DB1 RID: 19889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x9BE9", Offset = "0x9BE9", VA = "0x9BE9")]
		public PaymentBonusController(PaymentBonusModel model, PaymentBonusEvents events)
		{
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0x9BEA", Offset = "0x9BEA", VA = "0x9BEA", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x9BEB", Offset = "0x9BEB", VA = "0x9BEB", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x9BEC", Offset = "0x9BEC", VA = "0x9BEC")]
		private void ServicesServiceOnPaymentBonusAchievedEvent()
		{
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x9BED", Offset = "0x9BED", VA = "0x9BED")]
		private void RequestPaymentBonus()
		{
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x9BEE", Offset = "0x9BEE", VA = "0x9BEE")]
		private void HandleServiceGetPaymentBonus(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x9BEF", Offset = "0x9BEF", VA = "0x9BEF")]
		private IEnumerator CheckBacktimer()
		{
			return null;
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB8")]
		[Address(RVA = "0x9BF0", Offset = "0x9BF0", VA = "0x9BF0")]
		private void DestroyCheckBacktimerCoroutine()
		{
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB9")]
		[Address(RVA = "0x9BF1", Offset = "0x9BF1", VA = "0x9BF1")]
		private void ValidateInit()
		{
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DBA")]
		[Address(RVA = "0x9BF2", Offset = "0x9BF2", VA = "0x9BF2", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _servicesService;

		// Token: 0x04002A53 RID: 10835
		[Token(Token = "0x4002A53")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _checkBacktimerCoroutine;
	}
}
