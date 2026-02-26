using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.VortexRating.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.GreatOnesTab
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	public class GreatUserView : MonoBehaviour
	{
		// Token: 0x1400010F RID: 271
		// (add) Token: 0x06001545 RID: 5445 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010F")]
		public event Action<GreatUserView> LikeButtonClickedEvent
		{
			[Token(Token = "0x6001545")]
			[Address(RVA = "0x6707", Offset = "0x6707", VA = "0x6707")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001546")]
			[Address(RVA = "0x6708", Offset = "0x6708", VA = "0x6708")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000381")]
		public GreatUserData UserData
		{
			[Token(Token = "0x6001547")]
			[Address(RVA = "0x6709", Offset = "0x6709", VA = "0x6709")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001548")]
			[Address(RVA = "0x670A", Offset = "0x670A", VA = "0x670A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000382")]
		public Button LikeButton
		{
			[Token(Token = "0x6001549")]
			[Address(RVA = "0x670B", Offset = "0x670B", VA = "0x670B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000383")]
		public TextMeshProUGUI VortexRating
		{
			[Token(Token = "0x600154A")]
			[Address(RVA = "0x670C", Offset = "0x670C", VA = "0x670C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000384")]
		public TextMeshProUGUI LikesRating
		{
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x670D", Offset = "0x670D", VA = "0x670D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000385")]
		public GameAssetViewRawImage AvatarView
		{
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x670E", Offset = "0x670E", VA = "0x670E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000386")]
		public RewardsRender RewardsView
		{
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x670F", Offset = "0x670F", VA = "0x670F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000387")]
		public LevelCounter Level
		{
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x6710", Offset = "0x6710", VA = "0x6710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000388")]
		public TextMeshProUGUI Nickname
		{
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x6711", Offset = "0x6711", VA = "0x6711")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x6712", Offset = "0x6712", VA = "0x6712")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatUserView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatOnesTab_GreatUserView_LikeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581c8 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_VortexRating_View_GreatOnesTab_GreatUserView_LikeButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x6713", Offset = "0x6713", VA = "0x6713")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatUserView__OnDestroy
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  *(int *)(param1 + 0x30) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  iVar4 = *(int *)(param2 + 8);
		  local_4 = *(undefined4 *)(iVar4 + 0x10);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  local_4 = *(undefined4 *)(iVar4 + 0x14);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  UI_Elements_Counters_CounterAutoHide___ctor
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x20),0);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x18),0);
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(param2 + 0xc),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar3,uVar1,0);
		  piVar2 = (int *)func_ii_7307(*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param2 + 0x10),0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(param1 + 0x10),(uint)(*(char *)(param2 + 0x14) == '\0'),0);
		  return;
		}
		*/

		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x6714", Offset = "0x6714", VA = "0x6714")]
		public void Init(GreatUserData data)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatUserView__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x6715", Offset = "0x6715", VA = "0x6715")]
		private void LikeButtonClickedEventHandler()
		{
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x6716", Offset = "0x6716", VA = "0x6716")]
		public GreatUserView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatUserView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a581c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__GreatUserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a581c9 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__GreatUserData__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_ulong__GreatUserData___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80eb2059;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb2059:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetGreatRewardSet(uVar2,7,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _likeButton;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _vortexRating;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _likesRating;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewRawImage _avatarView;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _nickname;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_LikeButtonClickedEvent ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatUserView__add_LikeButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    DAT_ram_00a581c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GreatUserView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GreatUserView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Nickname ---
		void Gameplay_VortexRating_View_GreatOnesTab_GreatUserView__get_Nickname
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatOnesTab_GreatUserView_LikeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581c7 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_VortexRating_View_GreatOnesTab_GreatUserView_LikeButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
