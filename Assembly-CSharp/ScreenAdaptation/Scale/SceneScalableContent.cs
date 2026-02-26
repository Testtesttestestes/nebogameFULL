using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScreenAdaptation.Scale
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	public class SceneScalableContent : MonoBehaviour
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x5AF8", Offset = "0x5AF8", VA = "0x5AF8")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void ScreenAdaptation_Scale_SceneScalableContent__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      if (DAT_ram_00a5b8f1 == '\0') {
		        Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		        DAT_ram_00a5b8f1 = '\x01';
		      }
		      iVar4 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		      if (DAT_ram_00a5b80b == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Camera__Add__);
		        DAT_ram_00a5b80b = '\x01';
		      }
		      uVar3 = System_Collections_Generic_HashSet_object___Clear
		                        (*(undefined4 *)(iVar4 + 0x18),uVar3,
		                         Method_System_Collections_Generic_HashSet_Camera__Add__);
		      *(char *)(iVar4 + 0x20) = (char)uVar3;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      if (DAT_ram_00a5b8f1 == '\0') {
		        Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		        DAT_ram_00a5b8f1 = '\x01';
		      }
		      iVar4 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		      if (DAT_ram_00a5b80d == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Canvas__Add__);
		        DAT_ram_00a5b80d = '\x01';
		      }
		      uVar3 = System_Collections_Generic_HashSet_object___Clear
		                        (*(undefined4 *)(iVar4 + 0x1c),uVar3,
		                         Method_System_Collections_Generic_HashSet_Canvas__Add__);
		      *(char *)(iVar4 + 0x20) = (char)uVar3;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x5AF9", Offset = "0x5AF9", VA = "0x5AF9")]
		private void Start()
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x5AFA", Offset = "0x5AFA", VA = "0x5AFA")]
		public SceneScalableContent()
		{
		/* --- GHIDRA: .ctor ---
		int ScreenAdaptation_Scale_SceneScalableContent___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b812 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_ActionInfoAdapter_AuchanAdapter_TypeInfo);
		    DAT_ram_00a5b812 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_ActionInfoAdapter_AuchanAdapter_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera[] _cameras;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Canvas[] _canvases;
	}
}
