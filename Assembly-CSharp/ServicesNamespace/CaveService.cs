using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Cave;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public class CaveService : AbstractService
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000029")]
		public event Action<ProtoGetCaveInfoAns> NewMonsterInCave
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x5865", Offset = "0x5865", VA = "0x5865")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x5866", Offset = "0x5866", VA = "0x5866")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x17000095")]
		public override short ServiceId
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x5867", Offset = "0x5867", VA = "0x5867", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x5868", Offset = "0x5868", VA = "0x5868", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x5869", Offset = "0x5869", VA = "0x5869")]
		public OpToken<IMessage, object> SearchCave()
		{
			return null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x586A", Offset = "0x586A", VA = "0x586A")]
		public OpToken<IMessage, object> GetCaveInfo()
		{
			return null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043E")]
		private OpToken<IMessage, object> CaveRequest<TAns>(string cmdName, CaveCommands command) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x586B", Offset = "0x586B", VA = "0x586B")]
		public CaveService()
		{
		}
	}
}
