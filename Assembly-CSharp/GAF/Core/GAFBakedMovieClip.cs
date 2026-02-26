using System;
using System.Collections.Generic;
using GAF.Objects;
using GAFInternal.Core;
using GAFInternal.Data;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Core
{
	// Token: 0x020013E1 RID: 5089
	[Token(Token = "0x20013E1")]
	[AddComponentMenu("GAF/GAFBakedMovieClip")]
	[RequireComponent(typeof(GAFBakedObjectsManager))]
	[ExecuteInEditMode]
	public class GAFBakedMovieClip : GAFMovieClipInternal<GAFBakedObjectsManager>
	{
		// Token: 0x0600797B RID: 31099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797B")]
		[Address(RVA = "0xC25A", Offset = "0xC25A", VA = "0xC25A", Slot = "43")]
		protected override void setState(ref GAFObjectStateData _State, Dictionary<uint, IGAFObject> _Objects)
		{
		/* --- GHIDRA: setState ---
		void GAF_Core_GAFBakedMovieClip__setState(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54ea9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_GAFInternal_Core_GAFMovieClipInternal_GAFBakedObjectsManager___ctor__);
		    DAT_ram_00a54ea9 = '\x01';
		  }
		  GAFInternal_Objects_GAFBakedObjectsManagerInternal_object___updateToKeyFrame
		            (param1,Method_GAFInternal_Core_GAFMovieClipInternal_GAFBakedObjectsManager___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600797C RID: 31100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797C")]
		[Address(RVA = "0xC25B", Offset = "0xC25B", VA = "0xC25B")]
		public GAFBakedMovieClip()
		{
		/* --- GHIDRA: .ctor ---
		void GAF_Core_GAFBakedMovieClip___ctor(int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  undefined8 local_68;
		  undefined4 local_60;
		  undefined8 local_5c;
		  undefined4 local_54;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54eaa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IGAFObject__get_Item__);
		    Mono_Security_ASN1__get_Item(&GAFInternal_Objects_IGAFObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a54eaa = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(char *)(*(int *)(param1 + 0x30) + 0x66) == '\0') {
		    *(undefined4 *)(iVar4 + 0x50) = 0;
		  }
		  else {
		    uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,4);
		    *(undefined4 *)(iVar4 + 0x50) = uVar1;
		    if (DAT_ram_00a614b2 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Matrix4x4_TypeInfo);
		      DAT_ram_00a614b2 = '\x01';
		    }
		    iVar4 = *(int *)(UnityEngine_Matrix4x4_TypeInfo + 0x5c);
		    local_8 = *(undefined8 *)(iVar4 + 0x78);
		    local_10 = *(undefined8 *)(iVar4 + 0x70);
		    local_18 = *(undefined8 *)(iVar4 + 0x68);
		    local_20 = *(undefined8 *)(iVar4 + 0x60);
		    local_28 = *(undefined8 *)(iVar4 + 0x58);
		    local_30 = *(undefined8 *)(iVar4 + 0x50);
		    local_38 = *(undefined8 *)(iVar4 + 0x48);
		    local_40 = *(undefined8 *)(iVar4 + 0x40);
		    param1_00 = (int *)System_Collections_Generic_List_object___get_Item
		                                 (param3,*(undefined4 *)(*param2 + 8),
		                                  Method_System_Collections_Generic_Dictionary_uint__IGAFObject__get_Item__
		                                 );
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (GAFInternal_Objects_IGAFObject_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8))
		        {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80b2e1f1;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,GAFInternal_Objects_IGAFObject_TypeInfo,0);
		code_r0x80b2e1f1:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar4 = 0;
		    UnityEngine_Matrix4x4__get_Item(&local_40,0,*(float *)(*param2 + 0x10),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,4,*(float *)(*param2 + 0x18),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,1,*(float *)(*param2 + 0x14),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,5,*(float *)(*param2 + 0x1c),0);
		    iVar5 = *(int *)(iVar3 + 0xf4);
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      do {
		        iVar6 = *(int *)(*param2 + 0x50);
		        iVar5 = iVar5 + iVar4 * 0xc;
		        local_60 = *(undefined4 *)(iVar5 + 0x18);
		        local_68 = *(undefined8 *)(iVar5 + 0x10);
		        local_50 = local_68;
		        local_48 = local_60;
		        UnityEngine_Matrix4x4__MultiplyPoint(&local_5c,&local_40,&local_68,0);
		        iVar6 = iVar6 + iVar4 * 0xc;
		        *(undefined4 *)(iVar6 + 0x18) = local_54;
		        *(undefined8 *)(iVar6 + 0x10) = local_5c;
		        iVar4 = iVar4 + 1;
		        iVar5 = *(int *)(iVar3 + 0xf4);
		      } while (iVar4 < *(int *)(iVar5 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}
	}
}
