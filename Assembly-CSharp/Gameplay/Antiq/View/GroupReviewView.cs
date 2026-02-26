using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D82 RID: 3458
	[Token(Token = "0x2000D82")]
	[AddComponentMenu("Antiq/View/GroupReviewView")]
	internal class GroupReviewView : MonoBehaviour
	{
		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001136")]
		public GroupReviewView.Controls ArtifactControl
		{
			[Token(Token = "0x60054A3")]
			[Address(RVA = "0xA251", Offset = "0xA251", VA = "0xA251")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001137")]
		public GroupReviewView.Controls GroupControls
		{
			[Token(Token = "0x60054A4")]
			[Address(RVA = "0xA252", Offset = "0xA252", VA = "0xA252")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001138")]
		public GameAssetViewRawImage Image
		{
			[Token(Token = "0x60054A5")]
			[Address(RVA = "0xA253", Offset = "0xA253", VA = "0xA253")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001139")]
		public RectTransform GroupHeader
		{
			[Token(Token = "0x60054A6")]
			[Address(RVA = "0xA254", Offset = "0xA254", VA = "0xA254")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700113A")]
		public GroupReviewView.TextControls TextFields
		{
			[Token(Token = "0x60054A7")]
			[Address(RVA = "0xA255", Offset = "0xA255", VA = "0xA255")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700113B")]
		public Transform CurrentLevelCounter
		{
			[Token(Token = "0x60054A8")]
			[Address(RVA = "0xA256", Offset = "0xA256", VA = "0xA256")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700113C")]
		public Transform MaxLevelCounter
		{
			[Token(Token = "0x60054A9")]
			[Address(RVA = "0xA257", Offset = "0xA257", VA = "0xA257")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AA")]
		[Address(RVA = "0xA258", Offset = "0xA258", VA = "0xA258")]
		public void SetEnableGrayscale(bool value)
		{
		/* --- GHIDRA: SetEnableGrayscale ---
		void Gameplay_Antiq_View_GroupReviewView__SetEnableGrayscale(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59484 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a59484 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x30),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8100cd1a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8100cf5d:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100cf65;
		    }
		code_r0x8100cd1a:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8100cf5d;
		    if (iVar7 == 0) goto code_r0x8100cfae;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x8100cdf7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8100cf3f:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100cf65;
		    }
		code_r0x8100cdf7:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8100cf3f;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8100cf65;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8100cf65:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x8100cfae:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8100d03e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x8100d03e:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d8,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AB")]
		[Address(RVA = "0xA259", Offset = "0xA259", VA = "0xA259")]
		public void ClearEffects()
		{
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x1D27", Offset = "0x1D27", VA = "0x1D27")]
		public EffectView CreateEffectView()
		{
		/* --- GHIDRA: CreateEffectView ---
		void Gameplay_Antiq_View_GroupReviewView__CreateEffectView
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_Antiq_EffectsDicExt__GetMessage(*(undefined4 *)(param2 + 0xc),0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  piVar2 = *(int **)(param1 + 0x18);
		  uVar1 = Gameplay_Antiq_Model_EffectData__GetIntegerValue(param2,param1);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param3 != 0),0);
		  piVar2 = *(int **)(param1 + 0x10);
		  if (param3 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = Gameplay_Antiq_Model_EffectData__GetIntegerValue(param3,piVar2);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0xA25A", Offset = "0xA25A", VA = "0xA25A")]
		public GroupReviewView()
		{
		}

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GroupReviewView.Controls _groupControls;

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GroupReviewView.Controls _artifactControl;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GroupReviewView.TextControls _textControls;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private EffectView _effectPrefab;

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _maxLevelCounter;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _currentLevelCounter;

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ImageWithGrayscale[] _grayscales;

		// Token: 0x04002DDB RID: 11739
		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _effectsContainer;

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RectTransform _groupHeader;

		// Token: 0x02000D83 RID: 3459
		[Token(Token = "0x2000D83")]
		[Serializable]
		internal class Controls
		{
			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x060054AE RID: 21678 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700113D")]
			public Button Back
			{
				[Token(Token = "0x60054AE")]
				[Address(RVA = "0xA25B", Offset = "0xA25B", VA = "0xA25B")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x060054AF RID: 21679 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700113E")]
			public Button Next
			{
				[Token(Token = "0x60054AF")]
				[Address(RVA = "0xA25C", Offset = "0xA25C", VA = "0xA25C")]
				get
				{
					return null;
				}
			}

			// Token: 0x060054B0 RID: 21680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054B0")]
			[Address(RVA = "0xA25D", Offset = "0xA25D", VA = "0xA25D")]
			public Controls()
			{
			}

			// Token: 0x04002DDE RID: 11742
			[Token(Token = "0x4002DDE")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Button _back;

			// Token: 0x04002DDF RID: 11743
			[Token(Token = "0x4002DDF")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Button _next;
		}

		// Token: 0x02000D84 RID: 3460
		[Token(Token = "0x2000D84")]
		[Serializable]
		internal class TextControls
		{
			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x060054B1 RID: 21681 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700113F")]
			public TMP_Text CurrentEffectLevelTitle
			{
				[Token(Token = "0x60054B1")]
				[Address(RVA = "0xA25E", Offset = "0xA25E", VA = "0xA25E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x060054B2 RID: 21682 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001140")]
			public TMP_Text CurrentLevel
			{
				[Token(Token = "0x60054B2")]
				[Address(RVA = "0xA25F", Offset = "0xA25F", VA = "0xA25F")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x060054B3 RID: 21683 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001141")]
			public TMP_Text EffectLevelTitle
			{
				[Token(Token = "0x60054B3")]
				[Address(RVA = "0xA260", Offset = "0xA260", VA = "0xA260")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x060054B4 RID: 21684 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001142")]
			public TMP_Text GetMethodDescription
			{
				[Token(Token = "0x60054B4")]
				[Address(RVA = "0xA261", Offset = "0xA261", VA = "0xA261")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x060054B5 RID: 21685 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001143")]
			public TMP_Text GroupTitle
			{
				[Token(Token = "0x60054B5")]
				[Address(RVA = "0xA262", Offset = "0xA262", VA = "0xA262")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x060054B6 RID: 21686 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001144")]
			public TMP_Text[] MaxLevel
			{
				[Token(Token = "0x60054B6")]
				[Address(RVA = "0xA263", Offset = "0xA263", VA = "0xA263")]
				get
				{
					return null;
				}
			}

			// Token: 0x060054B7 RID: 21687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054B7")]
			[Address(RVA = "0xA264", Offset = "0xA264", VA = "0xA264")]
			public TextControls()
			{
			}

			// Token: 0x04002DE0 RID: 11744
			[Token(Token = "0x4002DE0")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private TMP_Text _currentEffectLevelTitle;

			// Token: 0x04002DE1 RID: 11745
			[Token(Token = "0x4002DE1")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private TMP_Text _currentLevel;

			// Token: 0x04002DE2 RID: 11746
			[Token(Token = "0x4002DE2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private TMP_Text _effectLevelTitle;

			// Token: 0x04002DE3 RID: 11747
			[Token(Token = "0x4002DE3")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private TMP_Text _getMethodDescription;

			// Token: 0x04002DE4 RID: 11748
			[Token(Token = "0x4002DE4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TMP_Text _groupTitle;

			// Token: 0x04002DE5 RID: 11749
			[Token(Token = "0x4002DE5")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private TMP_Text[] _maxLevel;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MaxLevelCounter ---
		void Gameplay_Antiq_View_GroupReviewView__get_MaxLevelCounter
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  float param2_00;
		  int iVar2;
		  
		  param2_00 = 1.0;
		  if (param2 == 0) {
		    param2_00 = 0.0;
		  }
		  iVar2 = *(int *)(param1 + 0x28);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),param2_00,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  AssetContent_GameAssetViewRawImage__TryGetCurrentContent
		            (*(undefined4 *)(param1 + 0x2c),param2_00,0);
		  return;
		}
		*/

}
