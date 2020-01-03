using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADPRepository;
//using ADPDataAccess;


namespace AwayDayPlanner.Model
{
    public class AdminModel
    {
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

        AdminRepository adminRepository = new AdminRepository();
        public int AdminloginUser()
        {
            var clientlist = adminRepository.GetAll();

            if (clientlist.Where(x => x.Username.ToLower().Contains(AdminUsername.ToLower())).Count() > 0)
            {
                var curr_client = clientlist.Where(x => x.Username.ToLower().Contains(AdminUsername.ToLower())).SingleOrDefault();
                var hashedBytesPwd = HashedPassword(AdminPassword);
                if (hashedBytesPwd == curr_client.AdminPassword)
                {
                    return curr_client.ID;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public string HashedPassword(string currentPasswordText)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(currentPasswordText);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }

    }
}
