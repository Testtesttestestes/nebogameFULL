using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	public class NotFoundWindowScript : NotFoundWindowObject
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021C")]
		public override string Message
		{
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x6171", Offset = "0x6171", VA = "0x6171", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x6172", Offset = "0x6172", VA = "0x6172")]
		public NotFoundWindowScript(string windowId, GameObject windowGameObject)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_NotFoundWindowScript___ctor(int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a639f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8133);
		    DAT_ram_00a639f4 = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  iVar3 = *(int *)(param1 + 0x48);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = iVar3;
		  iVar3 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar3;
		  iVar3 = *(int *)(param1 + 0x50);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = iVar3;
		  iVar3 = *(int *)(param1 + 0x54);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar3;
		  uVar2 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_8133,param2_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		private const string FORMAT = "Found window GameObject, but not found window script. [{0}] [{1}]";

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x4C")]
		public readonly GameObject WindowGameObject;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Message ---
		void UI_Windows_NotFoundWindowScript__get_Message
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a639f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Exception_TypeInfo);
		    DAT_ram_00a639f1 = '\x01';
		  }
		  if (*(int *)(System_Exception_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Exception_TypeInfo);
		  }
		  System_Exception__Init(param1,0);
		  *(undefined4 *)(param1 + 0x4c) = param3;
		  *(undefined4 *)(param1 + 0x48) = param2;
		  return;
		}
		*/

}
