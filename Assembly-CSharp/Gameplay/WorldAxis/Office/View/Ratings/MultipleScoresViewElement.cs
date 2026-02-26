using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	[Serializable]
	public class MultipleScoresViewElement
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x6422", Offset = "0x6422", VA = "0x6422")]
		public void Init(int count)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_Office_View_Ratings_MultipleScoresViewElement__Init
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  undefined8 local_8;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a58bb5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_int__TypeInfo);
		    DAT_ram_00a58bb5 = '\x01';
		  }
		  local_8 = 0;
		  do {
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_int__TypeInfo == *piVar6) {
		          puVar2 = (uint *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80f81540;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_int__TypeInfo,0);
		code_r0x80f81540:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar5 <= iVar4) {
		      return;
		    }
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_int__TypeInfo == *piVar6) {
		          puVar2 = (uint *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80f815bf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_int__TypeInfo,0);
		code_r0x80f815bf:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar4,puVar2[1]);
		    param1_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + iVar4 * 4 + 0x10);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_long__TypeInfo == *piVar6) {
		          puVar2 = (uint *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80f8164d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param3,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f8164d:
		    local_8 = (**(code **)((ulonglong)*puVar2 * 4))(param3,uVar3,puVar2[1]);
		    uVar3 = UnityEngine_GameObject__SetActive(&local_8,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar3,0);
		    iVar4 = iVar4 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x6423", Offset = "0x6423", VA = "0x6423")]
		public void UpdateScores(IList<int> indexes, IList<long> scores)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x6424", Offset = "0x6424", VA = "0x6424")]
		public MultipleScoresViewElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_MultipleScoresViewElement___ctor
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  Gameplay_Rating_View_UserView__get_UserData(*(undefined4 *)(param1 + 8),param2,0);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(param2 + 0x4c),0);
		  AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x14),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private TextMeshProUGUI _scorePrefab;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private RectTransform _scoreParent;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x10")]
		private TextMeshProUGUI[] _scores;
	}
}
