using System;
using AssetContent;
using Gameplay.School.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements;
using UnityEngine;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public class BasicSpellInfo : MonoBehaviourWithStates<BasicSpellInfo.State>
	{
		// Token: 0x06001071 RID: 4209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x626E", Offset = "0x626E", VA = "0x626E")]
		public void Init(SchoolSpellData spellData)
		{
		/* --- GHIDRA: Init ---
		void UI_Windows_Buildings_MageSchoolWindow_BasicSpellInfo__Init
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58ac6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__HandleCurrentStateChanged__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_13728);
		    DAT_ram_00a58ac6 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__HandleCurrentStateChanged__);
		  if (param3 == 2) {
		    param1_00 = *(undefined4 *)(param1 + 0x28);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13728,1,0,1,0,0,0,0);
		    UI_Elements_DecoratedTitle__Rebuild(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x626F", Offset = "0x626F", VA = "0x626F", Slot = "4")]
		protected override void HandleCurrentStateChanged(BasicSpellInfo.State fromState, BasicSpellInfo.State toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void UI_Windows_Buildings_MageSchoolWindow_BasicSpellInfo__HandleCurrentStateChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ac7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State___ctor__);
		    DAT_ram_00a58ac7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x6270", Offset = "0x6270", VA = "0x6270")]
		public BasicSpellInfo()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		UI_Windows_Buildings_MageSchoolWindow_BasicSpellInfo___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ac8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12647);
		    DAT_ram_00a58ac8 = '\x01';
		  }
		  return StringLiteral_12647;
		}
		*/

		}

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _currentLevel;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _nextLevel;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DecoratedTitle _title;

		// Token: 0x020002BB RID: 699
		[Token(Token = "0x20002BB")]
		public enum State
		{
			// Token: 0x04000870 RID: 2160
			[Token(Token = "0x4000870")]
			UNKNOWN_STATE,
			// Token: 0x04000871 RID: 2161
			[Token(Token = "0x4000871")]
			DEFAULT,
			// Token: 0x04000872 RID: 2162
			[Token(Token = "0x4000872")]
			EMPTY,
			// Token: 0x04000873 RID: 2163
			[Token(Token = "0x4000873")]
			MAX_LEVEL
		}
	}
}
