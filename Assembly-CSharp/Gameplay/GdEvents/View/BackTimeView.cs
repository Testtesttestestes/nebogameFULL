using System;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.GdEvents.View
{
	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x200071D")]
	public class BackTimeView : MonoBehaviour, IDisposable
	{
		// Token: 0x06002B92 RID: 11154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x7C29", Offset = "0x7C29", VA = "0x7C29")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_GdEvents_View_BackTimeView__OnDisable(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x18);
		  *(undefined4 *)(param1_00 + 0x14) = 0;
		  if (*(int *)(param1 + 0x28) != 0) {
		    *(undefined4 *)(param1 + 0x28) = 0;
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(param1_00,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x7C2A", Offset = "0x7C2A", VA = "0x7C2A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_BackTimeView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a263 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_BackTimeView_FormatBackTimeCallback__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    DAT_ram_00a5a263 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		  UI_AbstractBacktimeView___ctor
		            (param1_00,param1,Method_Gameplay_GdEvents_View_BackTimeView_FormatBackTimeCallback__,0)
		  ;
		  *(undefined4 *)(iVar1 + 0x14) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x7C2B", Offset = "0x7C2B", VA = "0x7C2B")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4 Gameplay_GdEvents_View_BackTimeView__Start(int param1,float param2,undefined4 param3)
		
		{
		  undefined8 param1_00;
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint uVar6;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5a264 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a264 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x28) + 0x14);
		  if (iVar4 == 0) {
		    iVar4 = *(int *)(Utils_TimeUtils_TypeInfo + 0x74);
		  }
		  else {
		    uVar6 = 0;
		    piVar5 = *(int **)(iVar4 + 0x10);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		          puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811ef982;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811ef982:
		    param1_00 = (**(code **)((ulonglong)*puVar1 * 4))
		                          (CONCAT44(in_register_20000004,piVar5),puVar1[1]);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar2 = Utils_StringUtils___cctor(param1_00,0);
		    piVar5 = *(int **)(param1 + 0x14);
		    if (param2 <= fVar2) {
		      uVar6 = *(uint *)(param1 + 0x1c);
		      local_8 = (float4)((float)(uVar6 >> 0x10 & 0xff) / 255.0);
		      local_4 = (float4)((float)(uVar6 >> 0x18) / 255.0);
		      local_10 = (float4)((float)(uVar6 & 0xff) / 255.0);
		      local_c = (float4)((float)(uVar6 >> 8 & 0xff) / 255.0);
		      local_18 = CONCAT44(local_4,local_8);
		      local_20 = CONCAT44(local_c,local_10);
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x178) * 4))
		                (piVar5,&local_20,*(undefined4 *)(*piVar5 + 0x17c));
		    }
		    else {
		      uVar6 = *(uint *)(param1 + 0x20);
		      local_8 = (float4)((float)(uVar6 >> 0x10 & 0xff) / 255.0);
		      local_4 = (float4)((float)(uVar6 >> 0x18) / 255.0);
		      local_10 = (float4)((float)(uVar6 & 0xff) / 255.0);
		      local_c = (float4)((float)(uVar6 >> 8 & 0xff) / 255.0);
		      local_28 = CONCAT44(local_4,local_8);
		      local_30 = CONCAT44(local_c,local_10);
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x178) * 4))
		                (piVar5,&local_30,*(undefined4 *)(*piVar5 + 0x17c));
		    }
		    Gameplay_GdEvents_View_BackTimeView__HandleDataChanged
		              (param1,*(undefined4 *)(param1 + 0x28),piVar5);
		    iVar4 = *(int *)(Utils_TimeUtils_TypeInfo + 0x74);
		  }
		  if (iVar4 == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar3 = Utils_TimeUtils__DateFormat((double)param2,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x7C2C", Offset = "0x7C2C", VA = "0x7C2C")]
		private string FormatBackTimeCallback(float value)
		{
		/* --- GHIDRA: FormatBackTimeCallback ---
		void Gameplay_GdEvents_View_BackTimeView__FormatBackTimeCallback
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x24) = param3;
		  if (param2 != *(int *)(param1 + 0x28)) {
		    *(int *)(param1 + 0x28) = param2;
		    if (param2 != 0) {
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),0);
		      Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(param1,param2,param1);
		      return;
		    }
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x18),0,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x7C2D", Offset = "0x7C2D", VA = "0x7C2D")]
		public void Init(GdEventData data, TimerStrings timerStrings)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_GdEvents_View_BackTimeView__Init(int param1,int param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x18);
		  if (param2 != *(int *)(param1 + 0x28)) {
		    *(int *)(param1 + 0x28) = param2;
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),0);
		    Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(param1,param2,param2);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_GdEvents_View_BackTimeView__Init(int param1,int param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x18);
		  if (param2 != *(int *)(param1 + 0x28)) {
		    *(int *)(param1 + 0x28) = param2;
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),0);
		    Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(param1,param2,param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x7C2E", Offset = "0x7C2E", VA = "0x7C2E")]
		public void Init(GdEventData data)
		{
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084E")]
		public GdEventData Data
		{
			[Token(Token = "0x6002B98")]
			[Address(RVA = "0x7C2F", Offset = "0x7C2F", VA = "0x7C2F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B99")]
			[Address(RVA = "0x7C30", Offset = "0x7C30", VA = "0x7C30")]
			private set
			{
			}
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x7C31", Offset = "0x7C31", VA = "0x7C31")]
		private void HandleDataChanged(GdEventData data)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  uint uVar2;
		  float fVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  iVar4 = **(int **)(param2 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                        (*(int **)(param2 + 0x14),param2,*(undefined4 *)(param1 + 0x24),
		                         *(undefined4 *)(iVar4 + 0x104));
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),param1_00,*(undefined4 *)(iVar4 + 0x2d4));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar2 ^ 1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  fVar3 = func_ii_7103(*(undefined4 *)(param2 + 0xc),0);
		  if (0.0 < fVar3) {
		    iVar4 = **(int **)(param2 + 0x14);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x108) * 4))
		                          (*(int **)(param2 + 0x14),param2,*(undefined4 *)(iVar4 + 0x10c));
		  }
		  else {
		    param2_00 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  iVar4 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  if (iVar4 == 0) {
		    uVar2 = 1;
		  }
		  else {
		    fVar3 = func_ii_7103(*(undefined4 *)(param2 + 0xc),0);
		    uVar2 = (uint)(0.0 < fVar3);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x7C32", Offset = "0x7C32", VA = "0x7C32")]
		private void ValidateState(GdEventData data)
		{
		/* --- GHIDRA: ValidateState ---
		void Gameplay_GdEvents_View_BackTimeView__ValidateState(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x28) != 0) {
		    *(undefined4 *)(param1 + 0x28) = 0;
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x18),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x7C33", Offset = "0x7C33", VA = "0x7C33", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x7C34", Offset = "0x7C34", VA = "0x7C34")]
		public BackTimeView()
		{
		}

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _timerNumbers;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color32 _warnColor;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color32 _color;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0x24")]
		private TimerStrings _timerStrings;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0x28")]
		private GdEventData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_BackTimeView__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x28)) {
		    *(int *)(param1 + 0x28) = param2;
		    if (param2 != 0) {
		      UI_Elements_RightPanel_TitleWithLevel__set_Level
		                (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),0);
		      Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(param1,param2,param2);
		      return;
		    }
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x18),0,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_BackTimeView__set_Data(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 0) {
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x18),0,0);
		    return;
		  }
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0xc),0);
		  Gameplay_GdEvents_View_BackTimeView__HandleDataChanged(param1,param2,param2);
		  return;
		}
		*/

}
