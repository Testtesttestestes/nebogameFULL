using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Shapes
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	public class CircleShape : AbstractShape
	{
		// Token: 0x06001B5A RID: 7002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x6CE0", Offset = "0x6CE0", VA = "0x6CE0", Slot = "5")]
		public override float[] GetParams()
		{
		/* --- GHIDRA: GetParams ---
		void Gameplay_Tutorial_Guide_Model_Shapes_CircleShape__GetParams
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  int iVar2;
		  
		  fVar1 = SQRT(*(float *)(param2 + 0x18) * *(float *)(param2 + 0x18) +
		               *(float *)(param2 + 0x14) * *(float *)(param2 + 0x14));
		  iVar2 = *(int *)(*(int *)(param2 + 8) + 0x24);
		  *param1 = CONCAT44(fVar1 * *(float *)(iVar2 + 0x20),*(float *)(iVar2 + 0x1c) * fVar1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x170004CB")]
		public override Vector2 Size
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x6CE1", Offset = "0x6CE1", VA = "0x6CE1", Slot = "6")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x6CE2", Offset = "0x6CE2", VA = "0x6CE2", Slot = "7")]
		public override bool TryGetSprite(out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x6CE3", Offset = "0x6CE3", VA = "0x6CE3")]
		public CircleShape()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Tutorial_Guide_Model_Shapes_CircleShape___ctor(int *param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  float4 fVar5;
		  float4 fVar6;
		  int iVar7;
		  undefined8 uVar8;
		  float fVar9;
		  float fVar10;
		  float fVar11;
		  undefined8 local_80;
		  undefined4 local_78;
		  undefined8 local_70;
		  undefined4 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  float4 local_40;
		  float4 local_3c;
		  undefined4 local_38;
		  float4 local_34;
		  float4 local_30;
		  undefined4 local_2c;
		  float4 local_28;
		  float4 local_24;
		  undefined4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  undefined4 local_14;
		  float4 local_10;
		  float4 local_c;
		  
		  if (DAT_ram_00a58492 == '\0') {
		    Mono_Security_ASN1__get_Item(&float___TypeInfo);
		    DAT_ram_00a58492 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (&local_10,param1,*(undefined4 *)(*param1 + 0xf4));
		  uVar8 = *(undefined8 *)(param1 + 3);
		  local_14 = 0;
		  local_48 = 0;
		  fVar11 = (float)param1[7] + (float)param1[7];
		  fVar9 = (float)local_c + fVar11;
		  fVar11 = (float)local_10 + fVar11;
		  fVar10 = -fVar11;
		  local_50 = CONCAT44(fVar9,fVar10);
		  local_1c = (float4)fVar10;
		  local_18 = (float4)fVar9;
		  UnityEngine_Transform__InverseTransformDirection(&local_10,param1[8],&local_50,0);
		  fVar4 = local_c;
		  fVar1 = local_10;
		  local_20 = 0;
		  local_58 = 0;
		  local_60 = CONCAT44(fVar9,fVar11);
		  local_28 = (float4)fVar11;
		  local_24 = (float4)fVar9;
		  UnityEngine_Transform__InverseTransformDirection(&local_10,param1[8],&local_60,0);
		  fVar5 = local_c;
		  fVar2 = local_10;
		  local_2c = 0;
		  local_68 = 0;
		  fVar9 = -fVar9;
		  local_70 = CONCAT44(fVar9,fVar11);
		  local_34 = (float4)fVar11;
		  local_30 = (float4)fVar9;
		  UnityEngine_Transform__InverseTransformDirection(&local_10,param1[8],&local_70,0);
		  fVar6 = local_c;
		  fVar3 = local_10;
		  local_38 = 0;
		  local_78 = 0;
		  local_80 = CONCAT44(fVar9,fVar10);
		  local_40 = (float4)fVar10;
		  local_3c = (float4)fVar9;
		  UnityEngine_Transform__InverseTransformDirection(&local_10,param1[8],&local_80,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,8);
		  fVar11 = (float)((ulonglong)uVar8 >> 0x20);
		  *(float *)(iVar7 + 0x2c) = (float)fVar4 * 0.5 + fVar11;
		  fVar10 = (float)uVar8;
		  *(float *)(iVar7 + 0x28) = (float)fVar1 * 0.5 + fVar10;
		  *(float *)(iVar7 + 0x1c) = (float)fVar6 * 0.5 + fVar11;
		  *(float *)(iVar7 + 0x18) = (float)fVar3 * 0.5 + fVar10;
		  *(float *)(iVar7 + 0x14) = (float)fVar5 * 0.5 + fVar11;
		  *(float *)(iVar7 + 0x10) = (float)fVar2 * 0.5 + fVar10;
		  *(float *)(iVar7 + 0x20) = (float)local_10 * 0.5 + fVar10;
		  *(float *)(iVar7 + 0x24) = (float)local_c * 0.5 + fVar11;
		  return iVar7;
		}
		*/

		}
	}
}
