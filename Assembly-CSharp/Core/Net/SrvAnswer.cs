using System;
using System.Runtime.CompilerServices;
using Core.Net.Factories;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net
{
	// Token: 0x02000E91 RID: 3729
	[Token(Token = "0x2000E91")]
	public class SrvAnswer : ISrvAnswer
	{
		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x17001275")]
		public uint CmdIndex
		{
			[Token(Token = "0x6005A9A")]
			[Address(RVA = "0xA787", Offset = "0xA787", VA = "0xA787", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A9C RID: 23196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001276")]
		public IMessage Message
		{
			[Token(Token = "0x6005A9B")]
			[Address(RVA = "0xA788", Offset = "0xA788", VA = "0xA788", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A9C")]
			[Address(RVA = "0xA789", Offset = "0xA789", VA = "0xA789")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A9E RID: 23198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001277")]
		[CanBeNull]
		public PacketParser.Packet Packet
		{
			[Token(Token = "0x6005A9D")]
			[Address(RVA = "0xA78A", Offset = "0xA78A", VA = "0xA78A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A9E")]
			[Address(RVA = "0xA78B", Offset = "0xA78B", VA = "0xA78B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x00010188 File Offset: 0x0000E388
		// (set) Token: 0x06005AA0 RID: 23200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001278")]
		public long Latency
		{
			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0xA78C", Offset = "0xA78C", VA = "0xA78C", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0xA78D", Offset = "0xA78D", VA = "0xA78D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0xA78E", Offset = "0xA78E", VA = "0xA78E")]
		private SrvAnswer(uint cmdIndex, short serviceId, uint eventId)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_SrvAnswer___ctor(int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a60594 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_IMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Factories_IProtocolMessageFactory_TypeInfo);
		    DAT_ram_00a60594 = '\x01';
		  }
		  if (param3 == (int *)0x0) {
		    *(int *)(param1 + 0x24) = param2;
		    return;
		  }
		  uVar1 = 0;
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Factories_IProtocolMessageFactory_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81cabc35;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Factories_IProtocolMessageFactory_TypeInfo,2);
		code_r0x81cabc35:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Google_Protobuf_IMessage_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81cabcb5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Google_Protobuf_IMessage_TypeInfo,3);
		code_r0x81cabcb5:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Google_Protobuf_MessageParser__CreateTemplate
		                    (*(undefined4 *)(iVar4 + 0x28),*(undefined4 *)(param2 + 0x10),0);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0xA78F", Offset = "0xA78F", VA = "0xA78F")]
		private void Parse(PacketParser.Packet packet, IProtocolMessageFactory factory)
		{
		/* --- GHIDRA: Parse ---
		int Core_Net_SrvAnswer__Parse(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined2 uVar1;
		  int param1_00;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60595 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvAnswer_TypeInfo);
		    DAT_ram_00a60595 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = *(undefined2 *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(param1 + 8);
		  param1_00 = unnamed_function_1417(Core_Net_SrvAnswer_TypeInfo);
		  if (DAT_ram_00a60593 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a60593 = '\x01';
		  }
		  *(undefined4 *)(param1_00 + 0x10) = uVar3;
		  *(undefined2 *)(param1_00 + 0xc) = uVar1;
		  *(undefined4 *)(param1_00 + 8) = uVar4;
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(undefined8 *)(param1_00 + 0x18) = uVar2;
		  Core_Net_SrvAnswer___ctor(param1_00,param1,param2,&local_20);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0xA790", Offset = "0xA790", VA = "0xA790")]
		public static SrvAnswer Create(PacketParser.Packet packet, IProtocolMessageFactory factory)
		{
		/* --- GHIDRA: Create ---
		undefined4 Core_Net_SrvAnswer__Create(undefined4 param1)
		
		{
		  if (DAT_ram_00a60597 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a60597 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  return *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8);
		}
		*/

		/* --- GHIDRA: Create ---
		undefined4 Core_Net_SrvAnswer__Create(undefined4 param1)
		
		{
		  if (DAT_ram_00a60597 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a60597 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  return *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8);
		}
		*/

			return null;
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0xA791", Offset = "0xA791", VA = "0xA791")]
		public static SrvAnswer Create(PacketParser.Packet packet, ISrvCommand cmd)
		{
			return null;
		}

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0xC")]
		public readonly short ServiceId;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x10")]
		public readonly uint EventId;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x18")]
		public readonly long ReceiveTimestamp;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Latency ---
		void Core_Net_SrvAnswer__set_Latency
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined8 uVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60593 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a60593 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined2 *)(param1 + 0xc) = (undefined2)param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(undefined8 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

}
