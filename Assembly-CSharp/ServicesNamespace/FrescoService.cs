using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Fresco;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class FrescoService : AbstractService
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x170000A2")]
		public override short ServiceId
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x5983", Offset = "0x5983", VA = "0x5983", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000068")]
		public event Action<ProtoFrescoUpdatedEvt> FrescoUpdatedEvent
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x5984", Offset = "0x5984", VA = "0x5984")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x5985", Offset = "0x5985", VA = "0x5985")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000069")]
		public event Action<ProtoFrescoUniversalFragmentsChangedEvt> FrescoUniversalFragmentsChangedEvent
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x5986", Offset = "0x5986", VA = "0x5986")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x5987", Offset = "0x5987", VA = "0x5987")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x5988", Offset = "0x5988", VA = "0x5988", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x5989", Offset = "0x5989", VA = "0x5989")]
		public OpToken<IMessage, object> GetUserFrescoes()
		{
			return null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x598A", Offset = "0x598A", VA = "0x598A")]
		public OpToken<IMessage, object> GetOtherUserFrescoes(ulong userId)
		{
			return null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x598B", Offset = "0x598B", VA = "0x598B")]
		public OpToken<IMessage, object> FillFrescoSlots(ulong frescoId, uint[] index)
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x598C", Offset = "0x598C", VA = "0x598C")]
		public OpToken<IMessage, object> CompleteFresco(ulong frescoId)
		{
			return null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x598D", Offset = "0x598D", VA = "0x598D")]
		public OpToken<IMessage, object> CollectFrescoReward(ulong frescoId)
		{
			return null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x598E", Offset = "0x598E", VA = "0x598E")]
		public OpToken<IMessage, object> InstallUniversalFragments(ulong frescoId, uint[] index)
		{
			return null;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x598F", Offset = "0x598F", VA = "0x598F")]
		public OpToken<IMessage, object> GetUniversalFragmentsCount()
		{
			return null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5990", Offset = "0x5990", VA = "0x5990")]
		public FrescoService()
		{
		}
	}
}
