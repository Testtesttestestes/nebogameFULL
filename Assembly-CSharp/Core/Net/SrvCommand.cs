using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Net.Factories;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net
{
	// Token: 0x02000E92 RID: 3730
	[Token(Token = "0x2000E92")]
	public class SrvCommand : ISrvCommand, IDisposable
	{
		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06005AA5 RID: 23205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AA6 RID: 23206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001279")]
		public static string SessionId
		{
			[Token(Token = "0x6005AA5")]
			[Address(RVA = "0xA792", Offset = "0xA792", VA = "0xA792")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AA6")]
			[Address(RVA = "0xA793", Offset = "0xA793", VA = "0xA793")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x1700127A")]
		public uint CommandIndex
		{
			[Token(Token = "0x6005AA7")]
			[Address(RVA = "0xA794", Offset = "0xA794", VA = "0xA794", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127B")]
		public string Name
		{
			[Token(Token = "0x6005AA8")]
			[Address(RVA = "0xA795", Offset = "0xA795", VA = "0xA795")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AA9")]
			[Address(RVA = "0xA796", Offset = "0xA796", VA = "0xA796")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x000101B8 File Offset: 0x0000E3B8
		// (set) Token: 0x06005AAB RID: 23211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127C")]
		public long Latency
		{
			[Token(Token = "0x6005AAA")]
			[Address(RVA = "0xA797", Offset = "0xA797", VA = "0xA797")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6005AAB")]
			[Address(RVA = "0xA798", Offset = "0xA798", VA = "0xA798")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x1700127D")]
		public long CreateTimestamp
		{
			[Token(Token = "0x6005AAC")]
			[Address(RVA = "0xA799", Offset = "0xA799", VA = "0xA799", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x000101E8 File Offset: 0x0000E3E8
		// (set) Token: 0x06005AAE RID: 23214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127E")]
		public long SerializeTimestamp
		{
			[Token(Token = "0x6005AAD")]
			[Address(RVA = "0xA79A", Offset = "0xA79A", VA = "0xA79A", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6005AAE")]
			[Address(RVA = "0xA79B", Offset = "0xA79B", VA = "0xA79B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127F")]
		public IMessage Message
		{
			[Token(Token = "0x6005AAF")]
			[Address(RVA = "0xA79C", Offset = "0xA79C", VA = "0xA79C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AB0")]
			[Address(RVA = "0xA79D", Offset = "0xA79D", VA = "0xA79D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0xA79E", Offset = "0xA79E", VA = "0xA79E", Slot = "9")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Net_SrvCommand__Dispose(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x38) = 0;
		  *(undefined8 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0xA79F", Offset = "0xA79F", VA = "0xA79F", Slot = "1")]
		protected override void Finalize()
		{
		/* --- GHIDRA: Finalize ---
		void Core_Net_SrvCommand__Finalize
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60599 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a60599 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x18) = 0xffffffffffffffff;
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4);
		  *(undefined4 *)(param1 + 0x30) = param5;
		  *(undefined2 *)(param1 + 0x12) = (undefined2)param4;
		  *(undefined2 *)(param1 + 0x10) = (undefined2)param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(undefined8 *)(param1 + 0x20) = uVar1;
		  *(int *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4) =
		       *(int *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4) + 1;
		  return;
		}
		*/

		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0xA7A0", Offset = "0xA7A0", VA = "0xA7A0")]
		private SrvCommand(string sId, short serviceId, short commandId, IMessage msg)
		{
		/* --- GHIDRA: .cctor ---
		void Core_Net_SrvCommand___cctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a605a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_IMessage_TypeInfo);
		    DAT_ram_00a605a0 = '\x01';
		  }
		  param2_00 = Google_Protobuf_IMessage_TypeInfo;
		  iVar2 = *(int *)(param1 + 0x34);
		  if (iVar2 != 0) {
		    if ((param2 != 0) &&
		       (iVar1 = func_ii_1082(param2,Google_Protobuf_IMessage_TypeInfo), iVar1 == 0)) {
		      System_Activator__CreateInstance(param2,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,iVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Net_SrvCommand___ctor(undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6059a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6059a = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  if (DAT_ram_00a60671 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a60671 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param2_00 = *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8);
		  param1_00 = unnamed_function_1417(Core_Net_SrvCommand_TypeInfo);
		  Core_Net_SrvCommand__Finalize(param1_00,param2_00,param1,param2,param3,param1_00);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0xA7A1", Offset = "0xA7A1", VA = "0xA7A1")]
		public static SrvCommand Create(short serviceId, short commandId, IMessage msg)
		{
			return null;
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001280")]
		public IProtocolMessageFactory MessageFactory
		{
			[Token(Token = "0x6005AB5")]
			[Address(RVA = "0xA7A2", Offset = "0xA7A2", VA = "0xA7A2", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AB6")]
			[Address(RVA = "0xA7A3", Offset = "0xA7A3", VA = "0xA7A3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB7")]
		public void SetCallback<TAnswer>(Action<SrvCommand, IMessage> callback) where TAnswer : IMessage, new()
		{
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001281")]
		public byte[] Payload
		{
			[Token(Token = "0x6005AB8")]
			[Address(RVA = "0xA7A4", Offset = "0xA7A4", VA = "0xA7A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0xA7A5", Offset = "0xA7A5", VA = "0xA7A5")]
		public void Execute(ISrvAnswer answer)
		{
		/* --- GHIDRA: Execute ---
		undefined4 Core_Net_SrvCommand__Execute(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int *param1_00;
		  undefined4 uVar1;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a6059d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_209);
		    Mono_Security_ASN1__get_Item(&StringLiteral_222);
		    Mono_Security_ASN1__get_Item(&StringLiteral_252);
		    Mono_Security_ASN1__get_Item(&StringLiteral_248);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_232);
		    Mono_Security_ASN1__get_Item(&StringLiteral_228);
		    DAT_ram_00a6059d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(param1_00,StringLiteral_5513,0);
		  func_ii_2010(param1_00,StringLiteral_222,0);
		  System_Text_StringBuilder__Append(param1_00,*(undefined4 *)(param1 + 0xc),0);
		  func_ii_2010(param1_00,StringLiteral_248,0);
		  func_ii_2010(param1_00,*(undefined4 *)(param1 + 8),0);
		  func_ii_2010(param1_00,StringLiteral_252,0);
		  System_Text_StringBuilder__Append(param1_00,(int)*(short *)(param1 + 0x10),0);
		  func_ii_2010(param1_00,StringLiteral_209,0);
		  System_Text_StringBuilder__Append(param1_00,(int)*(short *)(param1 + 0x12),0);
		  if (-1 < *(longlong *)(param1 + 0x18)) {
		    func_ii_2010(param1_00,StringLiteral_228,0);
		    param2_00 = *(undefined8 *)(param1 + 0x18);
		    System_Text_StringBuilder__Append(param1_00,param2_00,0);
		    in_register_20000014 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    func_ii_2010(param1_00,StringLiteral_232,0);
		    func_ii_2010(param1_00,*(undefined4 *)(param1 + 0x14),0);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,CONCAT44(in_register_20000014,*(undefined4 *)(*param1_00 + 0xdc)));
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x3643", Offset = "0x3643", VA = "0x3643")]
		public byte[] Serialize(IPacketParser parser)
		{
		/* --- GHIDRA: Serialize ---
		void Core_Net_SrvCommand__Serialize(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6167f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_ReadOnlySpan_byte__op_Implicit__);
		    DAT_ram_00a6167f = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x2c);
		  if (piVar3 == (int *)0x0) {
		    uVar1 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_14591);
		    func_ii_11454(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232(&Method_System_Net_Security_SslStream_CheckDisposed__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Span_ParticleSystem_Particle___op_Implicit
		            (&local_8,param2,Method_System_ReadOnlySpan_byte__op_Implicit__);
		  local_10 = local_8;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x1f0) * 4))
		            (piVar3,&local_10,*(undefined4 *)(*piVar3 + 500));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0xA7A6", Offset = "0xA7A6", VA = "0xA7A6", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Net_SrvCommand__ToString(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6059f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6059f = '\x01';
		  }
		  iVar1 = *(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar1 + 4) = 1;
		  *(undefined4 *)(iVar1 + 8) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  return;
		}
		*/

		/* --- GHIDRA: ToString ---
		void Core_Net_SrvCommand__ToString(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6059f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6059f = '\x01';
		  }
		  iVar1 = *(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar1 + 4) = 1;
		  *(undefined4 *)(iVar1 + 8) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0xA7A7", Offset = "0xA7A7", VA = "0xA7A7")]
		public string ToString([NotNull] ProtocolCommandInfoProvider infoProvider)
		{
			return null;
		}

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x0")]
		public static SynchronizationContext ExecuteContext;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x4")]
		public static uint GlobalCommandIndexSequence;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x8")]
		public readonly string SId;

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x10")]
		public readonly short ServiceId;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x12")]
		public readonly short CommandId;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		[FieldOffset(Offset = "0x34")]
		private Action<SrvCommand, IMessage> _callback;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x3C")]
		private byte[] _payload;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SessionId ---
		void Core_Net_SrvCommand__get_SessionId(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60598 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a60598 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8) = param1;
		  return;
		}
		*/


		/* --- GHIDRA: set_MessageFactory ---
		int Core_Net_SrvCommand__set_MessageFactory(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (iVar1 == 0) {
		    if (*(int *)(param1 + 0x30) == 0) {
		      return 0;
		    }
		    iVar1 = Google_Protobuf_MessageExtensions__MergeDelimitedFrom(*(int *)(param1 + 0x30),0);
		    *(int *)(param1 + 0x3c) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: SetCallback<object> ---
		void Core_Net_SrvCommand__SetCallback_object_(int param1,undefined4 param2,int param3)
		
		{
		  short sVar1;
		  short sVar2;
		  undefined4 uVar3;
		  int param1_00;
		  uint *puVar4;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  *(undefined4 *)(param1 + 0x34) = param2;
		  sVar1 = *(short *)(param1 + 0x12);
		  sVar2 = *(short *)(param1 + 0x10);
		  param1_00 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(param1_00 + 0xbd) & 1) == 0) {
		    param1_00 = func_ii_1079(param1_00);
		  }
		  uVar3 = unnamed_function_1417(param1_00);
		  puVar4 = *(uint **)(*(int *)(param3 + 0x1c) + 4);
		  (**(code **)((ulonglong)*puVar4 * 4))(uVar3,(int)sVar2,(int)sVar1,puVar4);
		  *(undefined4 *)(param1 + 0x38) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: SetCallback<__Il2CppFullySharedGenericType> ---
		void Core_Net_SrvCommand__SetCallback___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(param5 + 0x1c);
		  if (iVar2 == 0) {
		    Mono_Security_ASN1__get_Item(&System_Func_object__object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Expressions_StackGuard_RunOnEmptyStackCore_object___);
		    iVar2 = *(int *)(param5 + 0x1c);
		    if (iVar2 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		      iVar2 = *(int *)(param5 + 0x1c);
		    }
		  }
		  iVar2 = *(int *)(iVar2 + 4);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(param5 + 0x1c) + 4);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x5c) + 4);
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(*(int *)(param5 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		    }
		    iVar2 = *(int *)(*(int *)(param5 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    uVar1 = **(undefined4 **)(iVar2 + 0x5c);
		    iVar2 = unnamed_function_1417(System_Func_object__object__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar2,uVar1,*(undefined4 *)(*(int *)(param5 + 0x1c) + 8),0);
		    iVar3 = *(int *)(*(int *)(param5 + 0x1c) + 4);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    *(int *)(*(int *)(iVar3 + 0x5c) + 4) = iVar2;
		    iVar3 = *(int *)(*(int *)(param5 + 0x1c) + 4);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar3);
		    }
		  }
		  uVar1 = System_Tuple__Create_object__Memory_byte___object_
		                    (param2,param3,param4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 0x18));
		  System_Linq_Expressions_StackGuard__RunOnEmptyStack___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1,iVar2,uVar1,
		             Method_System_Linq_Expressions_StackGuard_RunOnEmptyStackCore_object___);
		  return;
		}
		*/


		/* --- GHIDRA: get_Payload ---
		void Core_Net_SrvCommand__get_Payload(int param1,int *param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a6059b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_ISrvAnswer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand__Execute_b__44_0__);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6059b = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Net_ISrvAnswer_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x81cac266;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Net_ISrvAnswer_TypeInfo,2);
		code_r0x81cac266:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  *(undefined8 *)(param1 + 0x18) = uVar1;
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Net_SrvCommand_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Threading_SendOrPostCallback_TypeInfo);
		  func_ii_13894(param1_00,param1,Method_Core_Net_SrvCommand__Execute_b__44_0__,0);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Net_ISrvAnswer_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x81cac32f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Net_ISrvAnswer_TypeInfo,1);
		code_r0x81cac32f:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar6 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0xe8) * 4))
		            (piVar5,param1_00,uVar4,*(undefined4 *)(iVar6 + 0xec));
		  return;
		}
		*/

}
