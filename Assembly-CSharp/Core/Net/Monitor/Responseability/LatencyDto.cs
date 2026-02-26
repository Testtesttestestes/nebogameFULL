using System;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E97 RID: 3735
	[Token(Token = "0x2000E97")]
	public class LatencyDto : IComparable
	{
		// Token: 0x06005ACD RID: 23245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0xA7B1", Offset = "0xA7B1", VA = "0xA7B1")]
		public LatencyDto(uint index, long latency)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Net_Monitor_Responseability_LatencyDto___ctor(int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a605a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9311);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10372);
		    DAT_ram_00a605a4 = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if (StringLiteral_9311 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_9311,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_9311;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[4] = iVar1;
		  local_4 = *(undefined4 *)(param1 + 8);
		  iVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar1;
		  if (StringLiteral_10372 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_10372,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_10372;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[6] = iVar1;
		  local_10 = *(undefined8 *)(param1 + 0x10);
		  iVar1 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28692,param2_00,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0xA7B2", Offset = "0xA7B2", VA = "0xA7B2", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4
		Core_Net_Monitor_Responseability_LatencyDto__ToString(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a605a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_LatencyDto_TypeInfo);
		    DAT_ram_00a605a5 = '\x01';
		  }
		  if (param2 == (int *)0x0) {
		    return 1;
		  }
		  if (((uint)*(byte *)(Core_Net_Monitor_Responseability_LatencyDto_TypeInfo + 0xb8) <=
		       (uint)*(byte *)(*param2 + 0xb8)) &&
		     (*(int *)(*(int *)(*param2 + 100) +
		               (uint)*(byte *)(Core_Net_Monitor_Responseability_LatencyDto_TypeInfo + 0xb8) * 4 + -4
		              ) == Core_Net_Monitor_Responseability_LatencyDto_TypeInfo)) {
		    uVar1 = System_Int64__CompareTo(param2 + 4,*(undefined8 *)(param1 + 0x10),0);
		    return uVar1;
		  }
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_11806);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Net_Monitor_Responseability_LatencyDto_CompareTo__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0xA7B3", Offset = "0xA7B3", VA = "0xA7B3", Slot = "4")]
		public int CompareTo(object obj)
		{
		/* --- GHIDRA: CompareTo ---
		void Core_Net_Monitor_Responseability_LatencyDto__CompareTo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ResponseAbilityStatus__TypeInfo);
		    DAT_ram_00a605a6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ResponseAbilityStatus__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ResponseAbilityStatus__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0;
		}

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint Index;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x10")]
		public long Latency;
	}
}
