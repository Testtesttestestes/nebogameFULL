using System;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000971 RID: 2417
	[Token(Token = "0x2000971")]
	public class TurnHint : MonoBehaviour
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x0000B700 File Offset: 0x00009900
		// (set) Token: 0x06003989 RID: 14729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4C")]
		public bool Visible
		{
			[Token(Token = "0x6003988")]
			[Address(RVA = "0x8919", Offset = "0x8919", VA = "0x8919")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003989")]
			[Address(RVA = "0x891A", Offset = "0x891A", VA = "0x891A")]
			set
			{
			}
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x891B", Offset = "0x891B", VA = "0x891B")]
		private void HandleVisibleChanged()
		{
		/* --- GHIDRA: HandleVisibleChanged ---
		void Gameplay_Combat_View_GameField_TurnHint__HandleVisibleChanged
		               (undefined4 param1,int param2,int param3,int param4,int param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a56765 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a56765 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = 0;
		  local_20 = 0;
		  local_8 = (float4)(float)(param5 - param3);
		  local_c = (float4)(float)(param4 - param2);
		  local_28 = CONCAT44(local_8,local_c);
		  UnityEngine_Transform__get_up(uVar1,&local_28,0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  iVar2 = UnityEngine_Mathf__Min(param2,param4,0);
		  iVar3 = UnityEngine_Mathf__Min(param3,param5,0);
		  iVar4 = UnityEngine_Mathf__Max(param2,param4,0);
		  iVar5 = UnityEngine_Mathf__Max(param3,param5,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_10 = 0;
		  local_30 = 0;
		  local_18 = (float4)((float)iVar2 * 88.0 + ((float)iVar4 - (float)iVar2) * 0.5 * 88.0);
		  local_14 = (float4)((float)iVar3 * 88.0 + ((float)iVar5 - (float)iVar3) * 0.5 * 88.0);
		  local_38 = CONCAT44(local_14,local_18);
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_38,0);
		  return;
		}
		*/

		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x891C", Offset = "0x891C", VA = "0x891C")]
		public void Move(int srcX, int srcY, int dstX, int dstY)
		{
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x891D", Offset = "0x891D", VA = "0x891D")]
		public TurnHint()
		{
		}

		// Token: 0x04001FD9 RID: 8153
		[Token(Token = "0x4001FD9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineAnimation _arrowAnimation;

		// Token: 0x04001FDA RID: 8154
		[Token(Token = "0x4001FDA")]
		[FieldOffset(Offset = "0x14")]
		private bool _visible;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Visible ---
		void Gameplay_Combat_View_GameField_TurnHint__get_Visible(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (param2 != *(byte *)(param1 + 0x14)) {
		    *(char *)(param1 + 0x14) = (char)param2;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x14),0);
		    if (*(char *)(param1 + 0x14) != '\0') {
		      param1_01 = *(int *)(param1 + 0x10);
		      if (*(char *)(param1_01 + 0x30) != '\0') {
		code_r0x80c75388:
		        Core_Animations_GameSpineAnimation__Init(param1_01,1,0);
		        return;
		      }
		      Core_Animations_GameSpineAnimation__Awake(param1_01,0);
		      if (*(char *)(param1 + 0x14) != '\0') {
		        param1_01 = *(int *)(param1 + 0x10);
		        goto code_r0x80c75388;
		      }
		    }
		    func_ii_7217(*(undefined4 *)(param1 + 0x10),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Visible ---
		void Gameplay_Combat_View_GameField_TurnHint__set_Visible(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x14),0);
		  if ((*(char *)(param1 + 0x14) != '\0') &&
		     ((*(char *)(*(int *)(param1 + 0x10) + 0x30) != '\0' ||
		      (Core_Animations_GameSpineAnimation__Awake(*(int *)(param1 + 0x10),0),
		      *(char *)(param1 + 0x14) != '\0')))) {
		    Core_Animations_GameSpineAnimation__Init(*(undefined4 *)(param1 + 0x10),1,0);
		    return;
		  }
		  func_ii_7217(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

}
