using System;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Objects
{
	// Token: 0x020013E0 RID: 5088
	[Token(Token = "0x20013E0")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[Serializable]
	public class GAFObjectsManager : GAFObjectsManagerInternal<GAFObject>
	{
		// Token: 0x06007979 RID: 31097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007979")]
		[Address(RVA = "0xC258", Offset = "0xC258", VA = "0xC258", Slot = "8")]
		public override void reload()
		{
		/* --- GHIDRA: reload ---
		void GAF_Objects_GAFObjectsManager__reload(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54ea7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_GAFInternal_Objects_GAFObjectsManagerInternal_GAFObject___ctor__);
		    DAT_ram_00a54ea7 = '\x01';
		  }
		  GAFInternal_Core_GAFMovieClipInternal_object___upgrade
		            (param1,Method_GAFInternal_Objects_GAFObjectsManagerInternal_GAFObject___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600797A RID: 31098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797A")]
		[Address(RVA = "0xC259", Offset = "0xC259", VA = "0xC259")]
		public GAFObjectsManager()
		{
		/* --- GHIDRA: .ctor ---
		void GAF_Objects_GAFObjectsManager___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  float fVar5;
		  float fVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
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
		  
		  if (DAT_ram_00a54ea8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IGAFObject__get_Item__);
		    Mono_Security_ASN1__get_Item(&GAFInternal_Objects_IGAFObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a54ea8 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(char *)(*(int *)(param1 + 0x30) + 0x66) == '\0') {
		    *(undefined4 *)(iVar4 + 0x50) = 0;
		  }
		  else {
		    uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,4);
		    *(undefined4 *)(iVar4 + 0x50) = uVar1;
		    fVar5 = *(float *)(*(int *)(param1 + 0x30) + 0xc);
		    fVar6 = *(float *)(*(int *)(param1 + 0x30) + 0x14);
		    if (DAT_ram_00a614b2 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Matrix4x4_TypeInfo);
		      DAT_ram_00a614b2 = '\x01';
		    }
		    fVar6 = fVar6 / fVar5;
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
		      uVar9 = 0;
		      do {
		        if (GAFInternal_Objects_IGAFObject_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8))
		        {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80b2dee3;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar9);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,GAFInternal_Objects_IGAFObject_TypeInfo,0);
		code_r0x80b2dee3:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar8 = 0;
		    UnityEngine_Matrix4x4__get_Item(&local_40,0,*(float *)(*param2 + 0x10),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,4,*(float *)(*param2 + 0x18),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,1,*(float *)(*param2 + 0x14),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,5,*(float *)(*param2 + 0x1c),0);
		    UnityEngine_Matrix4x4__get_Item
		              (&local_40,0xc,
		               *(float *)(*param2 + 0x2c) / fVar6 + *(float *)(*(int *)(iVar3 + 0xe8) + 0x2c) +
		               *(float *)(*(int *)(param1 + 0x30) + 0x30),0);
		    UnityEngine_Matrix4x4__get_Item
		              (&local_40,0xd,
		               (*(float *)(*(int *)(iVar3 + 0xe8) + 0x30) - *(float *)(*param2 + 0x30) / fVar6) +
		               *(float *)(*(int *)(param1 + 0x30) + 0x34),0);
		    UnityEngine_Matrix4x4__get_Item(&local_40,0xe,0.0,0);
		    iVar4 = *(int *)(iVar3 + 0xf4);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      do {
		        iVar7 = *(int *)(*param2 + 0x50);
		        iVar4 = iVar4 + iVar8 * 0xc;
		        local_60 = *(undefined4 *)(iVar4 + 0x18);
		        local_68 = *(undefined8 *)(iVar4 + 0x10);
		        local_50 = local_68;
		        local_48 = local_60;
		        UnityEngine_Matrix4x4__MultiplyPoint(&local_5c,&local_40,&local_68,0);
		        iVar7 = iVar7 + iVar8 * 0xc;
		        *(undefined4 *)(iVar7 + 0x18) = local_54;
		        *(undefined8 *)(iVar7 + 0x10) = local_5c;
		        iVar8 = iVar8 + 1;
		        iVar4 = *(int *)(iVar3 + 0xf4);
		      } while (iVar8 < *(int *)(iVar4 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}
	}
}
