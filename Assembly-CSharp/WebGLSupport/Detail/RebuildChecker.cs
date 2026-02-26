using System;
using Il2CppDummyDll;

namespace WebGLSupport.Detail
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class RebuildChecker
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x56B6", Offset = "0x56B6", VA = "0x56B6")]
		public RebuildChecker(IInputField input)
		{
		/* --- GHIDRA: .ctor ---
		int WebGLSupport_Detail_RebuildChecker___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a648d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20494);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20497);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20495);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20496);
		    DAT_ram_00a648d6 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0xc);
		  piVar5 = *(int **)(param1 + 8);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x825a350f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a350f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar6 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (uVar4,uVar3,0);
		  if (iVar6 != 0) {
		    if (param2 != 0) {
		      uVar1 = 0;
		      uVar4 = *(undefined4 *)(param1 + 0xc);
		      piVar5 = *(int **)(param1 + 8);
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		            goto code_r0x825a35a9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a35a9:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_20497,uVar4,uVar3,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		    }
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 8);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		          goto code_r0x825a3662;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a3662:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    *(undefined4 *)(param1 + 0xc) = uVar4;
		  }
		  iVar7 = *(int *)(param1 + 0x10);
		  piVar5 = *(int **)(param1 + 8);
		  iVar8 = *piVar5;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xf8);
		        goto code_r0x825a36f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,7);
		code_r0x825a36f2:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (iVar8 != iVar7) {
		    if (param2 != 0) {
		      local_4 = *(undefined4 *)(param1 + 0x10);
		      uVar1 = 0;
		      uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      piVar5 = *(int **)(param1 + 8);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xf8);
		            goto code_r0x825a379a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,7);
		code_r0x825a379a:
		      local_8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		      uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_20494,uVar4,uVar3,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		    }
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 8);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xf8);
		          goto code_r0x825a3868;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,7);
		code_r0x825a3868:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    *(undefined4 *)(param1 + 0x10) = uVar4;
		    iVar6 = 1;
		  }
		  uVar1 = 0;
		  iVar7 = *(int *)(param1 + 0x14);
		  piVar5 = *(int **)(param1 + 8);
		  iVar8 = *piVar5;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x108);
		        goto code_r0x825a38fc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,9);
		code_r0x825a38fc:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (iVar8 != iVar7) {
		    if (param2 != 0) {
		      local_4 = *(undefined4 *)(param1 + 0x14);
		      uVar1 = 0;
		      uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      piVar5 = *(int **)(param1 + 8);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x108);
		            goto code_r0x825a39a4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,9);
		code_r0x825a39a4:
		      local_8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		      uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_20496,uVar4,uVar3,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		    }
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 8);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x108);
		          goto code_r0x825a3a72;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,9);
		code_r0x825a3a72:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    *(undefined4 *)(param1 + 0x14) = uVar4;
		    iVar6 = 1;
		  }
		  uVar1 = 0;
		  iVar7 = *(int *)(param1 + 0x18);
		  piVar5 = *(int **)(param1 + 8);
		  iVar8 = *piVar5;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x118);
		        goto code_r0x825a3b06;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,0xb);
		code_r0x825a3b06:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (iVar8 != iVar7) {
		    if (param2 != 0) {
		      local_4 = *(undefined4 *)(param1 + 0x18);
		      uVar1 = 0;
		      uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      piVar5 = *(int **)(param1 + 8);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x118);
		            goto code_r0x825a3bae;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,0xb);
		code_r0x825a3bae:
		      local_8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		      uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_20495,uVar4,uVar3,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		    }
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 8);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x118);
		          goto code_r0x825a3c7c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,0xb);
		code_r0x825a3c7c:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    *(undefined4 *)(param1 + 0x18) = uVar4;
		    iVar6 = 1;
		  }
		  return iVar6;
		}
		*/

		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x56B7", Offset = "0x56B7", VA = "0x56B7")]
		public bool NeedRebuild(bool debug = false)
		{
			return default(bool);
		}

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x8")]
		private IInputField input;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0xC")]
		private string beforeString;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x10")]
		private int beforeCaretPosition;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x14")]
		private int beforeSelectionFocusPosition;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		private int beforeSelectionAnchorPosition;
	}
}
