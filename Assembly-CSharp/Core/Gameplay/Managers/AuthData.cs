using System;
using Core.Application.Managers;
using Il2CppDummyDll;
using Protocol.Auth2;
using Protocol.Tutorial;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200112E RID: 4398
	[Token(Token = "0x200112E")]
	public class AuthData
	{
		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x17001522")]
		public bool IsTester
		{
			[Token(Token = "0x6006710")]
			[Address(RVA = "0xB248", Offset = "0xB248", VA = "0xB248")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006711")]
		[Address(RVA = "0xB249", Offset = "0xB249", VA = "0xB249")]
		public AuthData(LoginCmd.Types.Ans loginAns, SigninRecord signinRecord)
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_AuthData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x14),0);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x18),0);
		    if (iVar1 == 0) {
		      uVar2 = (uint)(*(longlong *)(param1 + 8) != 0);
		    }
		    else {
		      uVar2 = 0;
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_AuthData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x14),0);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x18),0);
		    if (iVar1 == 0) {
		      uVar2 = (uint)(*(longlong *)(param1 + 8) != 0);
		    }
		    else {
		      uVar2 = 0;
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_AuthData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x14),0);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x18),0);
		    if (iVar1 == 0) {
		      uVar2 = (uint)(*(longlong *)(param1 + 8) != 0);
		    }
		    else {
		      uVar2 = 0;
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_AuthData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x14),0);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x18),0);
		    if (iVar1 == 0) {
		      uVar2 = (uint)(*(longlong *)(param1 + 8) != 0);
		    }
		    else {
		      uVar2 = 0;
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_AuthData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x14),0);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x18),0);
		    if (iVar1 == 0) {
		      uVar2 = (uint)(*(longlong *)(param1 + 8) != 0);
		    }
		    else {
		      uVar2 = 0;
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06006712 RID: 26386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006712")]
		[Address(RVA = "0xB24A", Offset = "0xB24A", VA = "0xB24A")]
		public AuthData(RegisterCmd.Types.Ans registerAns, SigninRecord signinRecord)
		{
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006713")]
		[Address(RVA = "0xB24B", Offset = "0xB24B", VA = "0xB24B")]
		public AuthData(ProtoStartTutorialAns tutorialAns, string identityCode)
		{
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006714")]
		[Address(RVA = "0xB24C", Offset = "0xB24C", VA = "0xB24C")]
		public AuthData(ulong userId, string sessionId, string dictPath, string dictName, string cdnPath, string email, uint userFlags)
		{
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006715")]
		[Address(RVA = "0xB24D", Offset = "0xB24D", VA = "0xB24D")]
		public AuthData(ulong userId, string sessionId, string dictPath, string dictName, string cdnPath)
		{
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x6006716")]
		[Address(RVA = "0xB24E", Offset = "0xB24E", VA = "0xB24E")]
		public bool CheckData()
		{
		/* --- GHIDRA: CheckData ---
		undefined4 Core_Gameplay_Managers_AuthData__CheckData(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_01;
		  int iVar4;
		  undefined1 local_1a;
		  byte local_19;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined1 local_d;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a932 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_IDictNameSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_Types_Result_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_RegisterCmd_Types_Result_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13441);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9917);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10649);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1246);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17269);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17343);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1242);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17340);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1247);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6536);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9947);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28690);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1268);
		    DAT_ram_00a5a932 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,0x12);
		  local_8 = *(undefined8 *)(param1 + 8);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_17343,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x10) = uVar2;
		  *(undefined4 *)(param1_00 + 0x14) = StringLiteral_6536;
		  param1_01 = *(int **)(param1 + 0x38);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_IDictNameSource_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81296bab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_Managers_IDictNameSource_TypeInfo,2);
		code_r0x81296bab:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_1247;
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(param1_00 + 0x24) = StringLiteral_1268;
		  *(undefined4 *)(param1_00 + 0x28) = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(param1_00 + 0x2c) = StringLiteral_1246;
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(param1_00 + 0x34) = StringLiteral_1242;
		  *(undefined4 *)(param1_00 + 0x38) = *(undefined4 *)(param1 + 0x1c);
		  *(undefined4 *)(param1_00 + 0x3c) = StringLiteral_1238;
		  local_c = *(undefined4 *)(param1 + 0x24);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_17340,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x40) = uVar2;
		  local_d = *(undefined1 *)(param1 + 0x28);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_d);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_17269,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x44) = uVar2;
		  local_14 = *(undefined4 *)(param1 + 0x2c);
		  uVar2 = func_ii_1081(Protocol_Auth2_LoginCmd_Types_Result_TypeInfo,&local_14);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_10649,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x48) = uVar2;
		  local_18 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = func_ii_1081(Protocol_Auth2_RegisterCmd_Types_Result_TypeInfo,&local_18);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_13441,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x4c) = uVar2;
		  local_19 = *(byte *)(param1 + 0x24) & 1;
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_19);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_9947,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x50) = uVar2;
		  local_1a = *(undefined1 *)(param1 + 0x29);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_1a);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28682,StringLiteral_9917,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x54) = uVar2;
		  uVar2 = System_Single__ToString(param1_00,0);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006717")]
		[Address(RVA = "0xB24F", Offset = "0xB24F", VA = "0xB24F", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Gameplay_Managers_AuthData__ToString(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a933 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDictNameSource__TypeInfo);
		    DAT_ram_00a5a933 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IDictNameSource__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IDictNameSource__TypeInfo), iVar2 == 0)) break;
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

			return null;
		}

		// Token: 0x040036F8 RID: 14072
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x8")]
		public ulong UserId;

		// Token: 0x040036F9 RID: 14073
		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x10")]
		public string Email;

		// Token: 0x040036FA RID: 14074
		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x14")]
		public readonly string SessionId;

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x18")]
		public readonly string DictPath;

		// Token: 0x040036FC RID: 14076
		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x1C")]
		public readonly string CdnPath;

		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x20")]
		public readonly string IdentityCode;

		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x24")]
		public readonly uint UserFlags;

		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0x28")]
		public readonly bool Update;

		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x29")]
		public readonly bool IsPaymateAvail;

		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0x2C")]
		public readonly LoginCmd.Types.Result LoginResult;

		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0x30")]
		public readonly RegisterCmd.Types.Result RegisterResult;

		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x34")]
		public readonly SigninRecord SigninRecord;

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x38")]
		public readonly IDictNameSource DictNameSource;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsTester ---
		void Core_Gameplay_Managers_AuthData__get_IsTester
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined8 uVar8;
		  
		  uVar2 = *(undefined4 *)(param2 + 0x20);
		  uVar3 = *(undefined4 *)(param2 + 0x24);
		  uVar4 = *(undefined4 *)(param2 + 0x30);
		  uVar5 = *(undefined4 *)(param2 + 0x2c);
		  uVar6 = *(undefined4 *)(param2 + 0x28);
		  uVar7 = *(undefined4 *)(param2 + 0x10);
		  uVar8 = *(undefined8 *)(param2 + 0x18);
		  if (DAT_ram_00a5a931 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DictNameSource_TypeInfo);
		    DAT_ram_00a5a931 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  *(undefined4 *)(param1 + 0x18) = uVar6;
		  *(undefined4 *)(param1 + 0x14) = uVar7;
		  *(undefined8 *)(param1 + 8) = uVar8;
		  iVar1 = unnamed_function_1417(Core_Gameplay_Managers_DictNameSource_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = uVar5;
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  *(int *)(param1 + 0x38) = iVar1;
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  *(undefined1 *)(param1 + 0x28) = *(undefined1 *)(param2 + 0x35);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  *(undefined4 *)(param1 + 0x34) = param3;
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  *(undefined1 *)(param1 + 0x29) = *(undefined1 *)(param2 + 0x34);
		  return;
		}
		*/

}
