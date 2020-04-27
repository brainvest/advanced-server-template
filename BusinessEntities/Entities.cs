//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheCads.SkillStreet.AdminTool {
	using System;
	using Microsoft.EntityFrameworkCore;
	using Brainvest.Dscribe.Abstractions;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Newtonsoft.Json;
	
	
	public partial class BusinessDbContext : Microsoft.EntityFrameworkCore.DbContext {
		
		public virtual DbSet<country> country { get; set; }
		public virtual DbSet<education> education { get; set; }
		public virtual DbSet<image_gallery> image_gallery { get; set; }
		public virtual DbSet<industry> industry { get; set; }
		public virtual DbSet<invited_user> invited_user { get; set; }
		public virtual DbSet<job_project_application> job_project_application { get; set; }
		public virtual DbSet<job_project_posted> job_project_posted { get; set; }
		public virtual DbSet<job_project_visit_count> job_project_visit_count { get; set; }
		public virtual DbSet<job_required_skill> job_required_skills { get; set; }
		public virtual DbSet<job_required_smart_skill> job_required_smart_skills { get; set; }
		public virtual DbSet<job_seeker_experience> job_seeker_experience { get; set; }
		public virtual DbSet<job_seeker_other_skill> job_seeker_other_skill { get; set; }
		public virtual DbSet<job_seeker_profile> job_seeker_profile { get; set; }
		public virtual DbSet<job_seeker_skill> job_seeker_skills { get; set; }
		public virtual DbSet<job_seeker_smart_skill> job_seeker_smart_skills { get; set; }
		public virtual DbSet<organization> organization { get; set; }
		public virtual DbSet<organization_detail> organization_details { get; set; }
		public virtual DbSet<organization_office> organization_office { get; set; }
		public virtual DbSet<organization_type> organization_type { get; set; }
		public virtual DbSet<organzation_user> organzation_users { get; set; }
		public virtual DbSet<other_skill> other_skill { get; set; }
		public virtual DbSet<skill> skill { get; set; }
		public virtual DbSet<smart_skill> smart_skills { get; set; }
		public virtual DbSet<state> state { get; set; }
		public virtual DbSet<user_details> user_details { get; set; }
		public virtual DbSet<work_benefit> work_benefits { get; set; }
		public virtual DbSet<work_experience> work_experience { get; set; }
		
		public BusinessDbContext(DbContextOptions options) : 
				base(options) {
		}
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("country")]
	public partial class country {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[InverseProperty("country")]
		public virtual System.Collections.Generic.ICollection<job_seeker_profile> job_seekers { get; set; }
		public virtual System.String name { get; set; }
		[JsonIgnore]
		[InverseProperty("country")]
		public virtual System.Collections.Generic.ICollection<organization_office> offices { get; set; }
		[JsonIgnore]
		[InverseProperty("country")]
		public virtual System.Collections.Generic.ICollection<organization_detail> organizations { get; set; }
		[JsonIgnore]
		[InverseProperty("country")]
		public virtual System.Collections.Generic.ICollection<organzation_user> organzation_users { get; set; }
		[JsonIgnore]
		[InverseProperty("country")]
		public virtual System.Collections.Generic.ICollection<state> states { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("education")]
	public partial class education {
		
		public virtual System.Int64? country { get; set; }
		[JsonIgnore]
		[ForeignKey("country")]
		public virtual country country_ref { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.String degree { get; set; }
		public virtual System.String field_of_study { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.Boolean? is_current { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_experience_id")]
		public virtual job_seeker_experience job_seeker_experience { get; set; }
		public virtual System.Int64? job_seeker_experience_id { get; set; }
		public virtual System.String location { get; set; }
		[JsonIgnore]
		[ForeignKey("org_id")]
		public virtual organization org { get; set; }
		public virtual System.Int64? org_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("image_gallery")]
	public partial class image_gallery {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.String image { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_details_id")]
		public virtual organization_detail organization_detail { get; set; }
		public virtual System.Int64 organization_details_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("industry")]
	public partial class industry {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.String name { get; set; }
		[JsonIgnore]
		[InverseProperty("industry")]
		public virtual System.Collections.Generic.ICollection<organization> organizations { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("invited_user")]
	public partial class invited_user {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_id")]
		public virtual organization organization { get; set; }
		public virtual System.Int64? organization_id { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_users_id")]
		public virtual organzation_user organization_user { get; set; }
		public virtual System.Int64? organization_users_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.String token { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		public virtual System.String user_email { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_project_application")]
	public partial class job_project_application {
		
		public virtual System.Int64? applied_date { get; set; }
		public virtual System.String contact_name { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.Int64? deactive_date { get; set; }
		public virtual System.String description { get; set; }
		public virtual System.String designation { get; set; }
		public virtual System.String email { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.Boolean? is_book_marked { get; set; }
		public virtual System.Boolean? is_salary_negotiable { get; set; }
		public virtual System.Int32? job_application_status { get; set; }
		[JsonIgnore]
		[ForeignKey("job_project_posted_id")]
		public virtual job_project_posted job_project_posted { get; set; }
		public virtual System.Int64? job_project_posted_id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64? job_seeker_id { get; set; }
		public virtual System.Int32? job_status { get; set; }
		public virtual System.String location { get; set; }
		public virtual System.Int64? published_date { get; set; }
		public virtual System.Double? salary_begin { get; set; }
		public virtual System.Double? salary_end { get; set; }
		public virtual System.Int32? seniority_level { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int32? terms { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_project_posted")]
	public partial class job_project_posted {
		
		[JsonIgnore]
		[ForeignKey("country_id")]
		public virtual country country { get; set; }
		public virtual System.Int64? country_id { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_details_id")]
		public virtual organization_detail organization_detail { get; set; }
		public virtual System.Int64? organization_details_id { get; set; }
		[JsonIgnore]
		[ForeignKey("published_by_id")]
		public virtual user_details published_by { get; set; }
		public virtual System.Int64? published_by_id { get; set; }
		[JsonIgnore]
		[InverseProperty("job_project_posted")]
		public virtual System.Collections.Generic.ICollection<job_required_skill> required_skills { get; set; }
		[JsonIgnore]
		[InverseProperty("job_project_posted")]
		public virtual System.Collections.Generic.ICollection<job_required_smart_skill> required_smart_skills { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		[JsonIgnore]
		[InverseProperty("job_project_posted")]
		public virtual System.Collections.Generic.ICollection<job_project_visit_count> visits { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_project_visit_count")]
	public partial class job_project_visit_count {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_project_posted_id")]
		public virtual job_project_posted job_project_posted { get; set; }
		public virtual System.Int64 job_project_posted_id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64 job_seeker_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_required_skills")]
	public partial class job_required_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_project_posted_id")]
		public virtual job_project_posted job_project_posted { get; set; }
		public virtual System.Int64? job_project_posted_id { get; set; }
		[JsonIgnore]
		[ForeignKey("skill_id")]
		public virtual skill skill { get; set; }
		public virtual System.Int64? skill_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_required_smart_skills")]
	public partial class job_required_smart_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_project_posted_id")]
		public virtual job_project_posted job_project_posted { get; set; }
		public virtual System.Int64? job_project_posted_id { get; set; }
		[JsonIgnore]
		[ForeignKey("smart_skills_id")]
		public virtual smart_skill smart_skill { get; set; }
		public virtual System.Int64? smart_skills_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_seeker_experience")]
	public partial class job_seeker_experience {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.Int64? end_date { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64? job_seeker_id { get; set; }
		public virtual System.Int64? order_sequence { get; set; }
		public virtual System.Int64? start_date { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int32? type { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_seeker_other_skill")]
	public partial class job_seeker_other_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64 job_seeker_id { get; set; }
		[JsonIgnore]
		[ForeignKey("other_skill_id")]
		public virtual other_skill other_skill { get; set; }
		public virtual System.Int64 other_skill_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_seeker_profile")]
	public partial class job_seeker_profile {
		
		public virtual System.String bio { get; set; }
		[JsonIgnore]
		[ForeignKey("country_id")]
		public virtual country country { get; set; }
		public virtual System.Int64? country_id { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[JsonIgnore]
		[InverseProperty("job_seeker")]
		public virtual System.Collections.Generic.ICollection<job_seeker_experience> experiences { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.Boolean? is_completed_smart_skills { get; set; }
		public virtual System.Boolean? is_exp_reordered { get; set; }
		[JsonIgnore]
		[InverseProperty("job_seeker")]
		public virtual System.Collections.Generic.ICollection<job_project_application> job_project_applications { get; set; }
		public virtual System.String location { get; set; }
		[JsonIgnore]
		[InverseProperty("job_seeker")]
		public virtual System.Collections.Generic.ICollection<job_seeker_other_skill> other_skills { get; set; }
		public virtual System.String profile_photo { get; set; }
		[JsonIgnore]
		[InverseProperty("job_seeker")]
		public virtual System.Collections.Generic.ICollection<other_skill> profile_visits { get; set; }
		[JsonIgnore]
		[InverseProperty("job_seeker")]
		public virtual System.Collections.Generic.ICollection<job_seeker_skill> skills { get; set; }
		[JsonIgnore]
		[InverseProperty("job_seeker")]
		public virtual System.Collections.Generic.ICollection<job_seeker_smart_skill> smart_skills { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		[JsonIgnore]
		[ForeignKey("user_details_id")]
		public virtual user_details user_detail { get; set; }
		public virtual System.Int64? user_details_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_seeker_skills")]
	public partial class job_seeker_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64 job_seeker_id { get; set; }
		public virtual System.String level { get; set; }
		[JsonIgnore]
		[ForeignKey("skill_id")]
		public virtual skill skill { get; set; }
		public virtual System.Int64 skill_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("job_seeker_smart_skills")]
	public partial class job_seeker_smart_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64 job_seeker_id { get; set; }
		[JsonIgnore]
		[ForeignKey("smart_skill_id")]
		public virtual smart_skill smart_skill { get; set; }
		public virtual System.Int64 smart_skill_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("organization")]
	public partial class organization {
		
		public virtual System.Boolean? activate { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("industry_id")]
		public virtual industry industry { get; set; }
		public virtual System.Int64? industry_id { get; set; }
		public virtual System.Boolean? is_verified { get; set; }
		public virtual System.String name { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_type_id")]
		public virtual organization_type organization_type { get; set; }
		public virtual System.Int64? organization_type_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		[JsonIgnore]
		[InverseProperty("organization")]
		public virtual System.Collections.Generic.ICollection<organzation_user> users { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("organization_details")]
	public partial class organization_detail {
		
		public virtual System.String bg_photo { get; set; }
		[JsonIgnore]
		[ForeignKey("country_id")]
		public virtual country country { get; set; }
		public virtual System.Int64? country_id { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.Int32? employee_size { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[InverseProperty("organization_detail")]
		public virtual System.Collections.Generic.ICollection<image_gallery> image_galleries { get; set; }
		[JsonIgnore]
		[InverseProperty("organization_detail")]
		public virtual System.Collections.Generic.ICollection<job_project_posted> job_project_posteds { get; set; }
		public virtual System.String location { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_id")]
		public virtual organization organization { get; set; }
		public virtual System.Int64? organization_id { get; set; }
		public virtual System.String profile_photo { get; set; }
		[JsonIgnore]
		[InverseProperty("organization_detail")]
		public virtual System.Collections.Generic.ICollection<other_skill> profile_visits { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.String story { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		public virtual System.String website { get; set; }
		[JsonIgnore]
		[InverseProperty("organization_detail")]
		public virtual System.Collections.Generic.ICollection<work_benefit> work_benefits { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("organization_office")]
	public partial class organization_office {
		
		[JsonIgnore]
		[ForeignKey("country_id")]
		public virtual country country { get; set; }
		public virtual System.Int64? country_id { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.Int64? latitude { get; set; }
		public virtual System.String location { get; set; }
		public virtual System.Int64? longitude { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_details_id")]
		public virtual organization_detail organization_detail { get; set; }
		public virtual System.Int64 organization_details_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("organization_type")]
	public partial class organization_type {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[InverseProperty("organization_type")]
		public virtual System.Collections.Generic.ICollection<organization> organizations { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.String type { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("organzation_users")]
	public partial class organzation_user {
		
		public virtual System.Boolean? activate { get; set; }
		[JsonIgnore]
		[ForeignKey("country_id")]
		public virtual country country { get; set; }
		public virtual System.Int64? country_id { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.String location { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_id")]
		public virtual organization organization { get; set; }
		public virtual System.Int64? organization_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		[JsonIgnore]
		[ForeignKey("user_details_id")]
		public virtual user_details user_detail { get; set; }
		public virtual System.Int64? user_details_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("other_skill")]
	public partial class other_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_id")]
		public virtual job_seeker_profile job_seeker { get; set; }
		public virtual System.Int64 job_seeker_id { get; set; }
		public virtual System.String name { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_details_id")]
		public virtual organization_detail organization_detail { get; set; }
		public virtual System.Int64 organization_details_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("skill")]
	public partial class skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[InverseProperty("skill")]
		public virtual System.Collections.Generic.ICollection<job_required_skill> job_required_skills { get; set; }
		public virtual System.String name { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("smart_skills")]
	public partial class smart_skill {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[InverseProperty("smart_skill")]
		public virtual System.Collections.Generic.ICollection<job_required_smart_skill> job_required_smart_skills { get; set; }
		public virtual System.String name { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("state")]
	public partial class state {
		
		[JsonIgnore]
		[ForeignKey("country_id")]
		public virtual country country { get; set; }
		public virtual System.Int64 country_id { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.String name { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("user_details")]
	public partial class user_details {
		
		public virtual System.Boolean? activate { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.String fname { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.String lname { get; set; }
		[JsonIgnore]
		[InverseProperty("user_detail")]
		public virtual System.Collections.Generic.ICollection<organzation_user> organzation_users { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
		public virtual System.String user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("work_benefits")]
	public partial class work_benefit {
		
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.String description { get; set; }
		public virtual System.String heading { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		[JsonIgnore]
		[ForeignKey("organization_details_id")]
		public virtual organization_detail organization_detail { get; set; }
		public virtual System.Int64 organization_details_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.ComponentModel.DataAnnotations.Schema.TableAttribute("work_experience")]
	public partial class work_experience {
		
		public virtual System.Int64? country { get; set; }
		[JsonIgnore]
		[ForeignKey("country")]
		public virtual country country_ref { get; set; }
		public virtual System.Int64 created_date { get; set; }
		[JsonIgnore]
		[ForeignKey("created_user_id")]
		public virtual user_details created_user { get; set; }
		public virtual System.Int64? created_user_id { get; set; }
		public virtual System.String description { get; set; }
		public virtual System.String designation { get; set; }
		[Key]
		public virtual System.Int64 id { get; set; }
		public virtual System.Boolean? is_current { get; set; }
		[JsonIgnore]
		[ForeignKey("job_seeker_experience_id")]
		public virtual job_seeker_experience job_seeker_experience { get; set; }
		public virtual System.Int64? job_seeker_experience_id { get; set; }
		public virtual System.String location { get; set; }
		[JsonIgnore]
		[ForeignKey("org_id")]
		public virtual organization org { get; set; }
		public virtual System.Int64? org_id { get; set; }
		public virtual System.Boolean status { get; set; }
		public virtual System.Int64 updated_date { get; set; }
		[JsonIgnore]
		[ForeignKey("updated_user_id")]
		public virtual user_details updated_user { get; set; }
		public virtual System.Int64? updated_user_id { get; set; }
	}
	
	[System.Composition.ExportAttribute(typeof(IBusinessRepositoryFactory))]
	public partial class DbContextFactory : IBusinessRepositoryFactory {
		
		public virtual IDisposable GetDbContext(DbContextOptions options){ return new BusinessDbContext(options); }
	}
}
